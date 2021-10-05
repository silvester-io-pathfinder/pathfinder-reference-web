using MudBlazor;

namespace Silvester.Pathfinder.Reference.Web.Themes
{
    public class DefaultTheme : MudTheme
    {
        public DefaultTheme()
        {
            Palette = new Palette
            {
                Primary = Colors.Red.Default,
                PrimaryContrastText = "#FFFFFF",
                Secondary = Colors.Orange.Accent3,
                SecondaryContrastText = "#FFFFFF",
                AppbarBackground = Colors.Red.Default,
                Tertiary = Colors.BlueGrey.Default,
            };

            LayoutProperties = new LayoutProperties
            {
                DrawerWidthLeft = "260px"
            };
        }
    }
}
