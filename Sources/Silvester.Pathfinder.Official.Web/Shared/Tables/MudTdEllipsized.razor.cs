using Microsoft.AspNetCore.Components;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables
{
    public partial class MudTdEllipsized 
    {
        [Parameter]
        public string DataLabel { get; set; } = default!;

        [Parameter]
        public string Text { get; set; } = default!;

        [Parameter] 
        public bool HideSmall { get; set; }
    }
}
