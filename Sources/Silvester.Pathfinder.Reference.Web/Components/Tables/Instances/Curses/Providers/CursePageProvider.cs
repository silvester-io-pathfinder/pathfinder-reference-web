using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Curses.Providers
{
    public class CursePageProvider : GraphqlPageProvider<ICursesPage, CurseSortInput>
    {
        public CursePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<ICursesPage>> GetPage(CurseSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetCursesPageResult> result = await PathfinderOfficialApi.GetCursesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Curses == null)
            {
                return EmptyPage();
            }

            TableData<ICursesPage> page = new TableData<ICursesPage>()
            {
                TotalItems = result.Data!.Curses!.TotalCount,
                Items = result.Data!.Curses!.Items!
            };

            return page;
        }
    }
}
