using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Utilities
{
    public class TextBlockAdapter : ITextBlock
    {
        public int Order { get; }

        public TextBlockType Type { get; }

        public string Text { get; }

        public TextBlockAdapter(int order, TextBlockType type, string text)
        {
            Order = order;
            Type = type;
            Text = text;
        }
    }
}
