using Silvester.Pathfinder.Reference.Web.Shared.Graphics;

namespace Silvester.Pathfinder.Reference.Web.Shared.Preferences.Builder.Models
{
    public class TextModel : IModel
    {
        public string? Title { get; set; } = default!;
        public string? Text { get; set; } = default!;
        public IconModel? Icon { get; set; } = default!;
        public bool HasBottomDivider { get; }

        public TextModel(string? title = null, string? text = null, IconModel? icon = null, bool hasBottomDivider = true)
        {
            Title = title;
            Text = text;
            Icon = icon;
            HasBottomDivider = hasBottomDivider;
        }

        public bool HasContent()
        {
            return string.IsNullOrWhiteSpace(Text) == false;
        }
    }
}
