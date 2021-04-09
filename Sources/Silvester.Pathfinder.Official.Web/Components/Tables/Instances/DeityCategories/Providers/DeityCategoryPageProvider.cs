using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.DeityCategories.Providers
{
    public class DeityCategoryPageProvider : GraphqlPageProvider<IDeityCategoriesPage, DeityCategorySortInput>
    {
        public DeityCategoryPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IDeityCategoriesPage>> GetPage(DeityCategorySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetDeityCategoriesPageResult> result = await PathfinderOfficialApi.GetDeityCategoriesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.DeityCategories == null)
            {
                return EmptyPage();
            }

            TableData<IDeityCategoriesPage> page = new TableData<IDeityCategoriesPage>()
            {
                TotalItems = result.Data!.DeityCategories!.TotalCount,
                Items = result.Data!.DeityCategories!.Items!
            };

            return page;
        }
    }
}
