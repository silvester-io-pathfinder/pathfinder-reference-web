using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Themes.Extensions
{
    public class CustomPalette : Palette
    {
        public string Footer { get; set; } = "rgba(255, 255, 255, 1)";
        public string FooterText { get; set; } = "rgba(255, 255, 255, 0.7)";
        public string FooterDark { get; set; } = "rgba(255, 255, 255, 0.25)";
    }

    public class CustomTheme : MudTheme
    {
        public new CustomPalette Palette 
        {
            get => (CustomPalette) base.Palette; 
            set => base.Palette = value; 
        }
    }
}
