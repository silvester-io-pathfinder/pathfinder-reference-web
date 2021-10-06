using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Themes.Extensions;

namespace Silvester.Pathfinder.Reference.Web.Themes
{
    public class DarkTheme : CustomTheme
    {
        private static readonly string BACKGROUND_DARKEST = "#121415";
        private static readonly string BACKGROUND_DARK = "#202225";
        private static readonly string BACKGROUND_DEFAULT = "#303237";
        private static readonly string BACKGROUND_LIGHT = "#40444b";
        private static readonly string TEXT = "#9eA2A7";
        private static readonly string PRIMARY = "#992e22";

        public DarkTheme()
        {
            Palette = new CustomPalette
            {
                Primary = PRIMARY,
                PrimaryContrastText = "#FFFFFF",
                Secondary = PRIMARY,
                SecondaryContrastText = "#FFFFFF",
                AppbarBackground = BACKGROUND_DARK,
                Tertiary = TEXT,

                Footer = BACKGROUND_DARK,
                FooterDark = BACKGROUND_DARKEST,
                FooterText = TEXT,

                Black = BACKGROUND_DEFAULT,
                Background = BACKGROUND_LIGHT,
                BackgroundGrey = BACKGROUND_LIGHT,
                Surface = BACKGROUND_DEFAULT,
                DrawerBackground = BACKGROUND_DARK,
                DrawerText = TEXT,
                DrawerIcon = "rgba(255,255,255, 0.50)",
                AppbarText = TEXT,
                TextPrimary = TEXT,
                TextSecondary = TEXT,
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                Divider = "rgba(255,255,255, 0.12)",
                DividerLight = "rgba(255,255,255, 0.12)",
                TableLines = "rgba(255,255,255, 0.12)",
                TableHover = "rgba(255,255,255, 0.03)",
                TableStriped = "rgba(255,255,255, 0.06)",
                LinesDefault = "rgba(255,255,255, 0.12)",
                LinesInputs = "rgba(255,255,255, 0.3)",
                TextDisabled = "rgba(255,255,255, 0.2)"
            };

            LayoutProperties = new LayoutProperties
            {
                DrawerWidthLeft = "260px"
            };
        }
    }
}
