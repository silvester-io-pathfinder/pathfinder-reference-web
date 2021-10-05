using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Shared.Footers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Footers
{
    public class SourceFooterBarItems : IEnumerable<IconFooterBar.Item>
    {
        private ISourcePage SourcePage { get; }

        public SourceFooterBarItems(ISourcePage sourcePage)
        {
            SourcePage = sourcePage;
        }

        private IEnumerable<IconFooterBar.Item> GetFooterItems()
        {
            yield return new IconFooterBar.Item((MarkupString) Icons.Generated.Book, SourcePage.Source.Name, "Book");
            yield return new IconFooterBar.Item((MarkupString) Icons.Generated.Hashtag, SourcePage.Page.ToString(), "Page");
        }

        public IEnumerator<IconFooterBar.Item> GetEnumerator()
        {
            return GetFooterItems().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
