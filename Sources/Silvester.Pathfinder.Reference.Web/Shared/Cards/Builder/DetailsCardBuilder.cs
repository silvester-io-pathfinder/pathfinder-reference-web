using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Reference.Icons;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using Silvester.Pathfinder.Reference.Web.Services;
using Silvester.Pathfinder.Reference.Web.Services.Currencies;
using Silvester.Pathfinder.Reference.Web.Shared.Footers;
using Silvester.Pathfinder.Reference.Web.Shared.Preferences.Builder.Models;
using Silvester.Pathfinder.Reference.Web.Shared.Tables.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Shared.Cards.Builder
{
    public class DetailsCardBuilder
    {
        private IList<CategoryModel.Builder> CategoriesLeft { get; }
        private IList<CategoryModel.Builder> CategoriesRight { get; }

        private string? Title { get; }
        private bool IsSharable { get; }

        public DetailsCardBuilder(string? title, bool isSharable)
        {
            CategoriesLeft = new List<CategoryModel.Builder>();
            CategoriesRight = new List<CategoryModel.Builder>();
            Title = title;
            IsSharable = isSharable;
        }

        public DetailsCardBuilder AddCategoryLeft(string? title, Action<CategoryModel.Builder> buildAction)
        {
            CategoryModel.Builder builder = new CategoryModel.Builder(title);
            buildAction.Invoke(builder);
            return AddCategoryLeft(builder);
        }

        public DetailsCardBuilder AddCategoryLeft(CategoryModel.Builder builder)
        {
            CategoriesLeft.Add(builder);
            return this;
        }

        public DetailsCardBuilder AddCategoryRight(string? title, Action<CategoryModel.Builder> buildAction)
        {
            CategoryModel.Builder builder = new CategoryModel.Builder(title);
            buildAction.Invoke(builder);
            return AddCategoryRight(builder);
        }

        public DetailsCardBuilder AddCategoryRight(CategoryModel.Builder builder)
        {
            CategoriesRight.Add(builder);
            return this;
        }

        public DetailsCardModel Build()
        {
            IList<CategoryModel> left = CategoriesLeft.Select(e => e.Build()).Where(e => e.Preferences.Count > 0 && e.Preferences.Any(p => p.HasContent())).ToList();
            IList<CategoryModel> right = CategoriesRight.Select(e => e.Build()).Where(e => e.Preferences.Count > 0 && e.Preferences.Any(p => p.HasContent())).ToList();
            return new DetailsCardModel(Title, IsSharable, left, right);
        }
    }

    public class DetailsCardModel
    {
        public string? Title { get; set; } = default!;

        public bool IsSharable { get; set; }

        public IList<CategoryModel> CategoriesLeft { get; set; } = default!;
        public IList<CategoryModel> CategoriesRight { get; set; } = default!;

        public DetailsCardModel(string? title, bool isSharable, IList<CategoryModel> categoriesLeft, IList<CategoryModel> categoriesRight)
        {
            Title = title;
            IsSharable = isSharable;
            CategoriesLeft = categoriesLeft;
            CategoriesRight = categoriesRight;
        }
    }
}
