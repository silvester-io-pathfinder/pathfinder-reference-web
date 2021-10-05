using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.ArmorCategories.Providers
{
    public class ArmorCategoryPageProvider : GraphqlPageProvider<IArmorCategoriesPage, ArmorCategorySortInput>
    {
        public ArmorCategoryPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IArmorCategoriesPage>> GetPage(ArmorCategorySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetArmorCategoriesPageResult> result = await PathfinderOfficialApi.GetArmorCategoriesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.ArmorCategories == null)
            {
                return EmptyPage();
            }

            TableData<IArmorCategoriesPage> page = new TableData<IArmorCategoriesPage>()
            {
                TotalItems = result.Data!.ArmorCategories!.TotalCount,
                Items = result.Data!.ArmorCategories!.Items!
            };

            return page;
        }
    }
}
