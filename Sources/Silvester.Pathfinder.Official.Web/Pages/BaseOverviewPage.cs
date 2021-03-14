using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Web.Pages
{
    public abstract class BaseOverviewPage : BasePage
    {
        protected abstract string Title { get; }

        protected override IReadOnlyList<string> GetTitleComponents()
        {
            return new[] { Title };
        }
    }
}
