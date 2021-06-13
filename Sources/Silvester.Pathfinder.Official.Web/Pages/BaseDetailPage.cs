using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Official.Web.Store.States.Actions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages
{
    public abstract class BaseDetailPage : BaseOverviewPage
    {
        [Parameter]
        public Guid ResourceId { get; set; }
        protected abstract string? ResourceName { get; }

        protected override IReadOnlyList<string?> GetTitleComponents()
        {
            return new[] { CollectionName, ResourceName };
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Dispatcher.Dispatch(new SetPageAction(CollectionName, ResourceName, ResourceId));
        }

        protected virtual void OnResourceLoaded()
        {
            Dispatcher.Dispatch(new SetPageAction(CollectionName, ResourceName, ResourceId));
            StateHasChanged();
        }
    }
}
