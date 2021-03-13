using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
