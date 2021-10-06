using Fluxor;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Store.States;
using Silvester.Pathfinder.Reference.Web.Themes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Shared
{
    public partial class MainLayout : IDisposable
    {
        [Inject]
        public IDispatcher Dispatcher { get; set; } = default!;

        [Inject]
        private IState<AppBarState>? AppBarState { get; set; }

        [Inject]
        private IState<DrawerState>? DrawerState { get; set; }

        [Inject]
        private IState<ThemeState> ThemeState { get; set; } = default!;

        private bool DrawerOpen { get; set; }

        public MainLayout()
        {
            DrawerOpen = true;
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            if (AppBarState != null)
            {
                AppBarState.StateChanged += OnStateChanged;
            }

            if (DrawerState != null)
            {
                DrawerState.StateChanged += OnStateChanged;
            }

            if (ThemeState != null)
            {
                ThemeState.StateChanged += OnStateChanged;
            }
        }

        private void OnStateChanged(object? sender, object state)
        {
            InvokeAsync(StateHasChanged);
        }

        private Task OnSwitchThemeClick()
        {
            if(ThemeState.Value.Theme == Theme.Light)
            {
                Console.WriteLine("Switching to dark theme.");
                Dispatcher.Dispatch(new SetThemeAction(Theme.Dark));
            }
            else
            {
                Console.WriteLine("Switching to light theme.");
                Dispatcher.Dispatch(new SetThemeAction(Theme.Light));
            }

            return Task.CompletedTask;
        }

        public void ToggleDrawer()
        {
            DrawerOpen = !DrawerOpen;
        }

        public void Dispose()
        {
            if (AppBarState != null)
            {
                AppBarState.StateChanged -= OnStateChanged;
            }

            if (DrawerState != null)
            {
                DrawerState.StateChanged -= OnStateChanged;
            }

            if (ThemeState != null)
            {
                ThemeState.StateChanged -= OnStateChanged;
            }
        }
    }
}
