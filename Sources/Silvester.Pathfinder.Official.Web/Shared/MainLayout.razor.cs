using Fluxor;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Store.States;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Web.Shared
{
    public partial class MainLayout : IDisposable
    {
        [Inject]
        private IState<AppBarState>? AppBarState { get; set; }

        [Inject]
        private IState<DrawerState>? DrawerState { get; set; }

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
        }

        private void OnStateChanged(object? sender, object state)
        {
            InvokeAsync(StateHasChanged);
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
        }
    }
}
