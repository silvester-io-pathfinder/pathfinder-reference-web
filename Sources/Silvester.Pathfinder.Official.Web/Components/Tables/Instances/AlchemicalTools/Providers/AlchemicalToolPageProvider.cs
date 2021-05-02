using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.AlchemicalTools.Providers
{
    public class AlchemicalToolPageProvider : GraphqlPageProvider<IAlchemicalToolsPage, AlchemicalToolSortInput>
    {
        public AlchemicalToolPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IAlchemicalToolsPage>> GetPage(AlchemicalToolSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAlchemicalToolsPageResult>? result = await PathfinderOfficialApi.GetAlchemicalToolsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.AlchemicalTools == null)
            {
                return EmptyPage();
            }

            TableData<IAlchemicalToolsPage> page = new TableData<IAlchemicalToolsPage>()
            {
                TotalItems = result.Data!.AlchemicalTools!.TotalCount,
                Items = result.Data!.AlchemicalTools!.Items!
            };

            return page;
        }
    }
}
