using Silvester.Pathfinder.Official.Web.Store.States.Actions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Entities
{
    public abstract class BaseOverviewPage : BasePage
    {
        protected abstract string CollectionName { get; }

        protected override IReadOnlyList<string?> GetTitleComponents()
        {
            return new[] { CollectionName };
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Dispatcher.Dispatch(new SetPageAction(CollectionName, null, null));
        }
    }
}
