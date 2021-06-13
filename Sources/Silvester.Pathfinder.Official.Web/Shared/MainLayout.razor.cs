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

        [Inject]
        private IState<BreadcrumbState>? BreadcrumbState { get; set; }

        private bool DrawerOpen { get; set; }

        public IEnumerable<BreadcrumbItem> GetBreadcrumbItems()
        {
            if (BreadcrumbState != null)
            {
                yield return new BreadcrumbItem(BreadcrumbState.Value.Collection, BreadcrumbState.Value.Collection.ToLower());
                if(BreadcrumbState.Value.ResourceName != null)
                {
                    yield return new BreadcrumbItem(BreadcrumbState.Value.ResourceName.ToLower(), $"{BreadcrumbState.Value.Collection.ToLower()}/{BreadcrumbState.Value.ResourceId}" );
                }
            }
        }

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

            if (BreadcrumbState != null)
            {
                BreadcrumbState.StateChanged += OnStateChanged;
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

            if (BreadcrumbState != null)
            {
                BreadcrumbState.StateChanged -= OnStateChanged;
            }
        }
    }
}
