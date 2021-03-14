using MudBlazor;

namespace Silvester.Pathfinder.Official.Web.Themes
{
    public class DefaultTheme : MudTheme
    {
        public DefaultTheme()
        {
            Palette = new Palette
            {
                Primary = Colors.Red.Default,
                Secondary = Colors.Orange.Accent3,
                AppbarBackground = Colors.Red.Default,
                Tertiary = Colors.BlueGrey.Default
            };

            LayoutProperties = new LayoutProperties
            {
                DrawerWidthLeft = "260px"
            };
        }
    }
}
