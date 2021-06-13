using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public record AppBarState(IReadOnlyList<string> TitleComponents);
    public record SetPageTitleAction(IReadOnlyList<string> TitleComponents);

    public class AppBarFeature : Feature<AppBarState>
    {
        public override string GetName() => "App Bar";
        protected override AppBarState GetInitialState() => new AppBarState(new[] { "Silvester Pathfinder" });

        [ReducerMethod]
        public static AppBarState ReduceTitle(AppBarState state, SetPageTitleAction action)
        {
            return new AppBarState(action.TitleComponents);
        }
    }
}
