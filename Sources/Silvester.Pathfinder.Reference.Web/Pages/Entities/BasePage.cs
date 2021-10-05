using Fluxor;
using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using Silvester.Pathfinder.Reference.Web.Store.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Silvester.Pathfinder.Reference.Web.Store.States.AppBarState;

namespace Silvester.Pathfinder.Reference.Web.Pages.Entities
{
    public class BasePage : ComponentBase
    {
        [Inject]
        protected IDispatcher Dispatcher { get; set; } = default!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected IPathfinderReferenceApi PathfinderReferenceApi { get; set; } = default!;

        protected virtual IReadOnlyList<string?> GetTitleComponents()
        {
            return Array.Empty<string>();
        }
    }
}
