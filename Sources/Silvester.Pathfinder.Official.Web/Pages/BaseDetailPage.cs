using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Web.Pages
{
    public abstract class BaseDetailPage : BaseOverviewPage
    {
        protected abstract string? Subtitle { get; }

        protected override IReadOnlyList<string?> GetTitleComponents()
        {
            return new[] { Title, Subtitle };
        }
    }
}
