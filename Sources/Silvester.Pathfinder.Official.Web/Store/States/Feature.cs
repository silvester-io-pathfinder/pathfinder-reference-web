using Fluxor;
using Silvester.Pathfinder.Official.Web.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public class Feature : Feature<AppBarState>
    {
        public override string GetName() => "AppBar";

        protected override AppBarState GetInitialState() => new AppBarState(new[] { "Silvester Pathfinder" });
    }
}
