using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Reference.Web.Store.States.Actions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Pages.Entities
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
