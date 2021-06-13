using Fluxor;
using Silvester.Pathfinder.Official.Web.Store.States.Actions;
using Silvester.Pathfinder.Official.Web.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public record AppBarState(string Title);

    public class AppBarFeature : Feature<AppBarState>
    {
        public override string GetName() => "App Bar";
        protected override AppBarState GetInitialState() => new AppBarState("Silvester Pathfinder");

        [ReducerMethod]
        public static AppBarState ReduceTitle(AppBarState state, SetPageAction action)
        {
            StringBuilder builder = new StringBuilder();
            string collection = action.Collection
                .Split("-")
                .Select(e => e.Capitalize())
                .Join(" ");

            builder.Append(collection);

            if(string.IsNullOrWhiteSpace(action.ResourceName) == false)
            {
                builder.Append(" - ");
                builder.Append(action.ResourceName);
            }

            return state with
            {
                Title = builder.ToString()
            };
        }
    }
}
