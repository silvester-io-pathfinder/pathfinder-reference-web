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
                Secondary = Colors.Orange.Accent4,
                AppbarBackground = Colors.Red.Default
            };

            LayoutProperties = new LayoutProperties
            {
                DrawerWidth = "260px"
            };
        }
    }
}
