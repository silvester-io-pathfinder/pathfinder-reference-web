using Microsoft.AspNetCore.Components;

namespace Silvester.Pathfinder.Official.Web.Shared.Preferences
{
    public partial class PreferenceCategory
    {
        [Parameter]
        public string Title { get; set; } = default!;

        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;
    }
}
