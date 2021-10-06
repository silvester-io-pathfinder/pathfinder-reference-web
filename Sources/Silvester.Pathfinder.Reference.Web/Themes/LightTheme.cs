using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Themes.Extensions;

namespace Silvester.Pathfinder.Reference.Web.Themes
{
    public class LightTheme : CustomTheme
    {
        public LightTheme()
        {
            Palette = new CustomPalette
            {
                Primary = Colors.Red.Default,
                PrimaryContrastText = "#FFFFFF",
                Secondary = Colors.Orange.Accent3,
                SecondaryContrastText = "#FFFFFF",
                AppbarBackground = Colors.Red.Default,
                Tertiary = Colors.BlueGrey.Default,

                Footer = Colors.Red.Default,
                FooterDark = "#b9000a",
                FooterText = "#FFFFFF",

                Background = "#F1F1F1",
            };

            LayoutProperties = new LayoutProperties
            {
                DrawerWidthLeft = "260px"
            };
        }
    }
}
