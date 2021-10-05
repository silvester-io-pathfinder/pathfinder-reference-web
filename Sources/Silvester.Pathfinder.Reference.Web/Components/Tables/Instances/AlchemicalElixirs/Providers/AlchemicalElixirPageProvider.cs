using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.AlchemicalElixirs.Providers
{
    public class AlchemicalElixirPageProvider : GraphqlPageProvider<IAlchemicalElixirsPage, AlchemicalElixirSortInput>
    {
        public AlchemicalElixirPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IAlchemicalElixirsPage>> GetPage(AlchemicalElixirSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAlchemicalElixirsPageResult>? result = await PathfinderReferenceApi.GetAlchemicalElixirsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.AlchemicalElixirs == null)
            {
                return EmptyPage();
            }

            TableData<IAlchemicalElixirsPage> page = new TableData<IAlchemicalElixirsPage>()
            {
                TotalItems = result.Data!.AlchemicalElixirs!.TotalCount,
                Items = result.Data!.AlchemicalElixirs!.Items!
            };

            return page;
        }
    }
}
