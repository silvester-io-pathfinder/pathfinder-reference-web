using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.State;
using System;

namespace Silvester.Pathfinder.Official.Web.Shared
{
    public partial class MainLayout : IDisposable
    {
        [Inject]
        private IState<AppBarState>? AppBarState { get; set; }
        
        private bool DrawerOpen { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }


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
        }

        private void OnStateChanged(object? sender, AppBarState state)
        {
            InvokeAsync(StateHasChanged);
        }

        public void ToggleDrawer()
        {
            DrawerOpen = !DrawerOpen;
        }

        public void Dispose()
        {
            if(AppBarState != null)
            {
                AppBarState.StateChanged -= OnStateChanged;
            }
        }
    }
}
