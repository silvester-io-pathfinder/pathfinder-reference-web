using Microsoft.AspNetCore.Components;

namespace Silvester.Pathfinder.Official.Web.Shared.Preferences
{
    public partial class PreferenceItemText
    {
        [Parameter]
        public string? Title { get; set; } = default!;
        
        [Parameter]
        public string Text { get; set; } = default!;
    }
}
