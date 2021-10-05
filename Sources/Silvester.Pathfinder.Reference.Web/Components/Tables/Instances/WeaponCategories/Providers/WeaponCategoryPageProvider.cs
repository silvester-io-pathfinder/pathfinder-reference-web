using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.WeaponCategories.Providers
{
    public class WeaponCategoryPageProvider : GraphqlPageProvider<IWeaponCategoriesPage, WeaponCategorySortInput>
    {
        public WeaponCategoryPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IWeaponCategoriesPage>> GetPage(WeaponCategorySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetWeaponCategoriesPageResult> result = await PathfinderOfficialApi.GetWeaponCategoriesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.WeaponCategories == null)
            {
                return EmptyPage();
            }

            TableData<IWeaponCategoriesPage> page = new TableData<IWeaponCategoriesPage>()
            {
                TotalItems = result.Data!.WeaponCategories!.TotalCount,
                Items = result.Data!.WeaponCategories!.Items!
            };

            return page;
        }
    }
}
