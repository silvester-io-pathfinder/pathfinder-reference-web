using Microsoft.AspNetCore.Components;

namespace Silvester.Pathfinder.Official.Web.Shared.Preferences
{
    public partial class PreferenceItemChips
    {
        [Parameter]
        public string? Title { get; set; } = default!;

        [Parameter]
        public RenderFragment Chips { get; set; } = default!;
    }
}
