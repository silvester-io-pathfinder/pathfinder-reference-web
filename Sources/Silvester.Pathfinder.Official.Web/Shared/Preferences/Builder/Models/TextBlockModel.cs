using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Web.Shared.Preferences.Builder.Models
{
    public class TextBlockModel : IModel
    {
        public IReadOnlyList<ITextBlock> TextBlocks { get; set; } = default!;
        public string? Title { get; set; }
        public bool HasBottomDivider { get; }

        public bool HasContent()
        {
            return TextBlocks.Count > 0;
        }

        public TextBlockModel(IReadOnlyList<ITextBlock> textBlocks, string? title = null, bool hasBottomDivider = true)
        {
            Title = title;
            HasBottomDivider = hasBottomDivider;
            TextBlocks = textBlocks;
        }
    }
}
