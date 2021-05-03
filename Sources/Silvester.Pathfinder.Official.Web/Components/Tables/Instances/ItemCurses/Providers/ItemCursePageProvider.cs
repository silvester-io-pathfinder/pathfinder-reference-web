using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.ItemCurses.Providers
{
    public class ItemCursePageProvider : GraphqlPageProvider<IItemCursesPage, ItemCurseSortInput>
    {
        public ItemCursePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IItemCursesPage>> GetPage(ItemCurseSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetItemCursesPageResult> result = await PathfinderOfficialApi.GetItemCursesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.ItemCurses == null)
            {
                return EmptyPage();
            }

            TableData<IItemCursesPage> page = new TableData<IItemCursesPage>()
            {
                TotalItems = result.Data!.ItemCurses!.TotalCount,
                Items = result.Data!.ItemCurses!.Items!
            };

            return page;
        }
    }
}
