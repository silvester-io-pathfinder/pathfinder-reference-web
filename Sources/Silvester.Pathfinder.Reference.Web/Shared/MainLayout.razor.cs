using Fluxor;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Shared.Appbar.Models;
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

        private IAppbarItem[] AppbarItems { get; } 

        private bool DrawerOpen { get; set; }

        public MainLayout()
        {
            DrawerOpen = true;
            AppbarItems = new IAppbarItem[]
            {
                new ActionItem("Switch Theme", MudBlazor.Icons.Material.Filled.Brightness4, OnSwitchThemeClick),
                new DividerItem(),
                new LinkItem("Patreon", Icons.Generated.Patreon, "https://www.patreon.com/pf2e_io"),
                new LinkItem("Discord", Icons.Generated.Discord, "https://discord.gg/hvTph7EX"),
                new LinkItem("Reddit Community", MudBlazor.Icons.Custom.Brands.Reddit, "https://www.reddit.com/r/pathfinder2e/"),
                new LinkItem("Twitter", MudBlazor.Icons.Custom.Brands.Twitter, "https://twitter.com/pf2e_io/"),
                new LinkItem("GitHub Repositories", MudBlazor.Icons.Custom.Brands.GitHub, "https://github.com/silvester-io-pathfinder")
            };
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
