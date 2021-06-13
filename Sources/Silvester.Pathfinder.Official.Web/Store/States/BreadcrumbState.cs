using Fluxor;
using Silvester.Pathfinder.Official.Web.Store.States.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public record BreadcrumbState(string Collection, string? ResourceName, Guid? ResourceId);

    public class BreadcrumbFeature : Feature<BreadcrumbState>
    {
        public override string GetName() => "Breadcrumbs";
        protected override BreadcrumbState GetInitialState() => new BreadcrumbState("actions", null, null);

        [ReducerMethod]
        public static BreadcrumbState ReducePage(BreadcrumbState state, SetPageAction action)
        {
            return state with
            {
                Collection = action.Collection,
                ResourceName = action.ResourceName,
                ResourceId  = action.ResourceId
            };
        }
    }
}
