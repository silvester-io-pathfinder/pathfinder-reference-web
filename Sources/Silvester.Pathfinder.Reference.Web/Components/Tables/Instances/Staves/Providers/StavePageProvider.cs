using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Staves.Providers
{
    public class StavePageProvider : GraphqlPageProvider<IStavesPage, StaveSortInput>
    {
        public StavePageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IStavesPage>> GetPage(StaveSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetStavesPageResult> result = await PathfinderReferenceApi.GetStavesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.Staves == null)
            {
                return EmptyPage();
            }

            TableData<IStavesPage> page = new TableData<IStavesPage>()
            {
                TotalItems = result.Data!.Staves!.TotalCount,
                Items = result.Data!.Staves!.Items!
            };

            return page;
        }
    }
}
