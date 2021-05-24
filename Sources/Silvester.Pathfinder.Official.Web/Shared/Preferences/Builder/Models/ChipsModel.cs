using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Web.Shared.Preferences.Builder.Models
{
    public class ChipsModel : IModel
    {
        public string? Title { get; set; } = default!;
        public IList<ChipModel> Chips { get; set; } = default!;
        public bool HasBottomDivider { get; }

        public ChipsModel(IList<ChipModel> chips, string? title = null, bool hasBottomDivider = true)
        {
            Title = title;
            Chips = chips;
            HasBottomDivider = hasBottomDivider;
        }

        public bool HasContent()
        {
            return Chips.Count > 0 && Chips.Any(e => string.IsNullOrWhiteSpace(e.Text) == false);
        }

        public class ChipModel
        {
            public Action? OnClick { get; set; }
            public string? Text { get; set; } = default!;
            public string? Tooltip { get; set; }

            public ChipModel(string? text, string? tooltip = null, Action? onClick = null)
            {
                OnClick = onClick;
                Text = text;
                Tooltip = tooltip;
            }
        }

        public class Builder
        {
            private IList<ChipModel> Chips { get; }
            private string? Title { get; }
            private bool HasBottomDivider { get; }

            public Builder(string? title = null, bool hasBottomDivider = true)
            {
                Chips = new List<ChipModel>();
                Title = title;
                HasBottomDivider = hasBottomDivider;
            }

            public Builder AddChip(string text, string? tooltip = null, Action? onClick = null)
            {
                return AddChip(new ChipModel(text, tooltip, onClick));
            }

            public Builder AddChip(ChipModel model)
            {
                Chips.Add(model);
                return this;
            }

            public Builder AddChips(IEnumerable<ChipModel> models)
            {
                foreach (ChipModel model in models)
                {
                    Chips.Add(model);
                }
                return this;
            }

            public ChipsModel Build()
            {
                return new ChipsModel(Chips, Title, HasBottomDivider);
            }
        }
    }
}
