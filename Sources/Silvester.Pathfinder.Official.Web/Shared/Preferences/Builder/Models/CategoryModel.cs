using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Shared.Preferences.Builder.Models
{
    public class CategoryModel
    {
        public string? Title { get; set; } = default!;
        public IList<IModel> Preferences { get; set; } = default!;

        public CategoryModel(string? title, IList<IModel> preferences)
        {
            Title = title;
            Preferences = preferences;
        }

        public class Builder
        {
            private IList<IModel> Preferences { get; }
            private string? Title { get; }

            public Builder(string? title)
            {
                Preferences = new List<IModel>();
                Title = title;
            }

            public Builder AddText(TextModel model)
            {
                return AddPreference(model);
            }

            public Builder AddAction(string? title, string actionTypeName, IActionTypeService actionTypeService, bool hasBottomDivider = true)
            {
                return AddText(title, actionTypeName, actionTypeService.GetActionTypeIcon(actionTypeName), hasBottomDivider);
            }

            public Builder AddText(string? title = null, string? text = null, string? icon = null, bool hasBottomDivider = true)
            {
                return AddPreference(new TextModel(title, text, icon, hasBottomDivider));
            }

            public Builder AddChips(ChipsModel model)
            {
                return AddPreference(model);
            }

            public Builder AddRollableEffect(IRollableEffect? effect, bool hasBottomDividers = true)
            {
                if(effect == null)
                {
                    return this;
                }

                return this
                    .AddText("Critical Success", effect.Name, hasBottomDivider: hasBottomDividers)
                    .AddText("Success", effect.Success, hasBottomDivider: hasBottomDividers)
                    .AddText("Failure", effect.Failure, hasBottomDivider: hasBottomDividers)
                    .AddText("Critical Failure", effect.CriticalFailure, hasBottomDivider: hasBottomDividers);    
            }

            public Builder AddSingularChip(string? title, ChipsModel.ChipModel model, bool hasBottomDivider = true)
            {
                return AddPreference(new ChipsModel(new[] { model }, title, hasBottomDivider));
            }

            public Builder AddSingularChip(string? title, string? text, Action? onClick, bool hasBottomDivider = true)
            {
                return AddPreference(new ChipsModel(new[] { new ChipsModel.ChipModel(text, onClick: onClick) }, title, hasBottomDivider));
            }

            public Builder AddTraitChips(IReadOnlyList<ITraitChip> chips, NavigationManager navigationManager, bool hasBottomDivider = true)
            {
                return AddChips("Traits", builder =>
                {
                    builder.AddChips(chips.Select(e => new ChipsModel.ChipModel(e.Name, onClick: () => navigationManager.NavigateTo($"traits/{e.Id}"))));
                }, hasBottomDivider: hasBottomDivider);
            }

            public Builder AddChips(string? title, Action<ChipsModel.Builder> buildAction, bool hasBottomDivider = true)
            {
                ChipsModel.Builder builder = new ChipsModel.Builder(title, hasBottomDivider);
                buildAction.Invoke(builder);

                return AddPreference(builder.Build());
            }

            public Builder AddTextBlock(TextBlockModel model)
            {
                return AddPreference(model);
            }

            public Builder AddTextBlock(IReadOnlyList<ITextBlock> textBlocks, string? title = null, bool hasBottomDivider = true)
            {
                return AddPreference(new TextBlockModel(textBlocks, title, hasBottomDivider));
            }

            public Builder AddFooter(Action<FooterModel.Builder> buildAction)
            {
                FooterModel.Builder builder = new FooterModel.Builder();
                buildAction.Invoke(builder);

                return AddPreference(builder.Build());
            }

            public Builder AddFooter(FooterModel model)
            {
                return AddPreference(model);
            }

            public Builder AddPreference(IModel model)
            {
                Preferences.Add(model);
                return this;
            }

            public CategoryModel Build()
            {
                return new CategoryModel(Title, Preferences);
            }
        }
    }
}
