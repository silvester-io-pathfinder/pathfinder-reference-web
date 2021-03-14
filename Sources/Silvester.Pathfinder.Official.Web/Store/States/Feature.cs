using Fluxor;
using Silvester.Pathfinder.Official.Web.State;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public class Feature : Feature<AppBarState>
    {
        public override string GetName() => "AppBar";

        protected override AppBarState GetInitialState() => new AppBarState(new[] { "Silvester Pathfinder" });
    }
}
