
using MudBlazor;

namespace Silvester.Pathfinder.Official.Web
{
    public partial class App
    {
        public MudTheme Theme { get; }

        public App()
        {
            Theme = new MudTheme()
            {
                Palette = new Palette()
                {
                    Primary = Colors.Orange.Default,
                    Secondary = Colors.Red.Accent2,
                    AppbarBackground = Colors.Orange.Default,
                },

                LayoutProperties = new LayoutProperties()
                {
                    DrawerWidthLeft = "260px"
                }
            };
        }
    }
}
