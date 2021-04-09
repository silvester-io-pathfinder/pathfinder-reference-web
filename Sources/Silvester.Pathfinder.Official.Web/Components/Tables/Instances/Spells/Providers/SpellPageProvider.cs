using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Spells.Providers
{
    public class SpellPageProvider : IPageProvider<ISpellsPage, SpellSortInput>
    {
        private PathfinderOfficialApi PathfinderOfficialApi { get;}

        public SpellPageProvider(PathfinderOfficialApi pathfinderOfficialApi)
        {
            PathfinderOfficialApi = pathfinderOfficialApi;
        }

        public async Task<TableData<ISpellsPage>> GetPage(SpellSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetSpellsPageResult> result = await PathfinderOfficialApi.GetSpellsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            TableData<ISpellsPage> page = new TableData<ISpellsPage>()
            {
                TotalItems = result.Data!.Spells!.TotalCount,
                Items = result.Data!.Spells!.Items!
            };

            return page;
        }
    }
}
