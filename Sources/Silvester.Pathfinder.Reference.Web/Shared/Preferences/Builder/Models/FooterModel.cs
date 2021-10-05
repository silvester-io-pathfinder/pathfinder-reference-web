using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Official.Icons;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Services.Currencies;
using Silvester.Pathfinder.Official.Web.Shared.Footers;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Web.Shared.Preferences.Builder.Models
{
    public class FooterModel : IModel
    {
        public IList<IconFooterBar.Item> Items { get; set; } = default!;
        public bool HasBottomDivider => false;
        public string? InspectionUrl { get; }

        public FooterModel(IList<IconFooterBar.Item> items, string? inspectionUrl)
        {
            Items = items;
            InspectionUrl = inspectionUrl;
        }

        public bool HasContent()
        {
            return Items.Count > 0;
        }

        public class Builder
        {
            private IList<IconFooterBar.Item> Items { get; set; }
            private string? InspectionUrl { get; set; }

            public Builder()
            {
                Items = new List<IconFooterBar.Item>();
            }

            public Builder AddBulk(IBulk? bulk)
            {
                if(bulk == null)
                {
                    return this;
                }

                return AddItem(new IconFooterBar.Item((MarkupString)Generated.Weight, bulk.Name, "Bulk"));
            }

            public Builder AddDifficultyCheck(int? difficultyCheck)
            {
                if (difficultyCheck == null)
                {
                    return this;
                }

                return AddItem(new IconFooterBar.Item((MarkupString)Generated.Check, difficultyCheck.ToString()!, "Difficulty Check"));
            }

            public Builder AddArmorClass(int? armorClass)
            {
                if (armorClass == null)
                {
                    return this;
                }

                return AddItem(new IconFooterBar.Item((MarkupString)Generated.Armor, armorClass.ToString()!, "Armor Class"));
            }

            public Builder AddLevel(int? level)
            {
                if(level == null)
                {
                    return this;
                }

                return AddItem(new IconFooterBar.Item((MarkupString)Generated.Slider, level.ToString()!, "Level"));
            }

            public Builder AddInspectionUrl(string? inspectionUrl)
            {
                InspectionUrl = inspectionUrl;
                return this;
            }

            public Builder AddSourcePage(ISourcePage? sourcePage)
            {
                if(sourcePage == null)
                {
                    return this;
                }

                return this
                    .AddItem(new IconFooterBar.Item((MarkupString)Generated.Book, sourcePage.Source.Name, "Source"))
                    .AddItem(new IconFooterBar.Item((MarkupString)Generated.Hashtag, sourcePage.Page.ToString(), "Page"));
            }

            public Builder AddPrice(int price, ICurrencyService currencyService)
            {
                return AddItem(new IconFooterBar.Item((MarkupString)Generated.Coins, currencyService.Denormalize(price, Coin.Types.Gold).ToString(), "Price"));
            }

            public Builder AddHardware(int hardness, int hitPoints, int brokenThreshold)
            {
                return this
                    .AddItem(new IconFooterBar.Item((MarkupString)Generated.Pickaxe, hardness.ToString(), "Hardness"))
                    .AddItem(new IconFooterBar.Item((MarkupString)Generated.Health, hitPoints.ToString(), "Hit Points"))
                    .AddItem(new IconFooterBar.Item((MarkupString)Generated.BrokenHealth, brokenThreshold.ToString(), "Broken Threshold"));
            }

            public Builder AddItem(IconFooterBar.Item item)
            {
                Items.Add(item);
                return this;
            }

            public FooterModel Build()
            {
                return new FooterModel(Items, InspectionUrl);
            }
        }
    }
}
