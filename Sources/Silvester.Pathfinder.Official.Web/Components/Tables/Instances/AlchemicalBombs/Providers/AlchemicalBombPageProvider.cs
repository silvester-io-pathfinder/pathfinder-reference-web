using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.AlchemicalBombs.Providers
{
    public class AlchemicalBombPageProvider : GraphqlPageProvider<IAlchemicalBombsPage, AlchemicalBombSortInput>
    {
        public AlchemicalBombPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IAlchemicalBombsPage>> GetPage(AlchemicalBombSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAlchemicalBombsPageResult>? result = await PathfinderOfficialApi.GetAlchemicalBombsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.AlchemicalBombs == null)
            {
                return EmptyPage();
            }

            TableData<IAlchemicalBombsPage> page = new TableData<IAlchemicalBombsPage>()
            {
                TotalItems = result.Data!.AlchemicalBombs!.TotalCount,
                Items = result.Data!.AlchemicalBombs!.Items!
            };

            return page;
        }
    }
}
