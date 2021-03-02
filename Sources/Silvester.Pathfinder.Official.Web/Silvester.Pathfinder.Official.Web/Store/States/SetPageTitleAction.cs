using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
