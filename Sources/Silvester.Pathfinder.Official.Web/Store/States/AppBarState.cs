using System.Collections.Generic;

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
