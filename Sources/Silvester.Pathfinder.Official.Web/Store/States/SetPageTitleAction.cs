using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public record SetPageTitleAction
    {
        public IReadOnlyList<string> TitleComponents { get; }

        public SetPageTitleAction(IReadOnlyList<string> titleComponents)
        {
            TitleComponents = titleComponents;
        }
    }
}
