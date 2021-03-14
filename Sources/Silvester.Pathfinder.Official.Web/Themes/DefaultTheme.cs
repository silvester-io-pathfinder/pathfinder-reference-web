using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Themes
{
    public class DefaultTheme : MudTheme
    {
        public DefaultTheme()
        {
            Palette = new Palette
            {
                Primary = Colors.Red.Default,
                Secondary = "#495165",
                AppbarBackground = Colors.Red.Default
            };

            LayoutProperties = new LayoutProperties
            {
                DrawerWidthLeft = "260px"
            };
        }
    }
}
