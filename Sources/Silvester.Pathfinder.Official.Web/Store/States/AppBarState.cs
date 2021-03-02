using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.State
{
    public record AppBarState
    {
        public IReadOnlyList<string> TitleComponents { get; }

        public AppBarState(IReadOnlyList<string> titleComponents)
        {
            TitleComponents = titleComponents;
        }
    }
}
