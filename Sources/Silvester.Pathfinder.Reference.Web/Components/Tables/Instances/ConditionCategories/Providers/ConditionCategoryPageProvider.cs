using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.ConditionCategories.Providers
{
    public class ConditionCategoryPageProvider : GraphqlPageProvider<IConditionCategoriesPage, ConditionCategorySortInput>
    {
        public ConditionCategoryPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IConditionCategoriesPage>> GetPage(ConditionCategorySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetConditionCategoriesPageResult> result = await PathfinderOfficialApi.GetConditionCategoriesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.ConditionCategories == null)
            {
                return EmptyPage();
            }

            TableData<IConditionCategoriesPage> page = new TableData<IConditionCategoriesPage>()
            {
                TotalItems = result.Data!.ConditionCategories!.TotalCount,
                Items = result.Data!.ConditionCategories!.Items!
            };

            return page;
        }
    }
}
