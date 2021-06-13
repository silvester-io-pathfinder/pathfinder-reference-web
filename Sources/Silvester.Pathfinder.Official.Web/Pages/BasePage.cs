using Fluxor;
using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Store.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Silvester.Pathfinder.Official.Web.Store.States.AppBarState;

namespace Silvester.Pathfinder.Official.Web.Pages
{
    public class BasePage : ComponentBase
    {
        [Inject]
        protected IDispatcher Dispatcher { get; set; } = default!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        protected IPathfinderOfficialApi PathfinderOfficialApi { get; set; } = default!;

        protected virtual IReadOnlyList<string?> GetTitleComponents()
        {
            return Array.Empty<string>();
        }
    }
}
