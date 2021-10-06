using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.AncestryRarities.Providers
{
    public class AncestryRarityPageProvider : GraphqlPageProvider<IRaritiesPage, RaritySortInput>
    {
        public AncestryRarityPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IRaritiesPage>> GetPage(RaritySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetRaritiesPageResult> result = await PathfinderReferenceApi.GetRaritiesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.Rarities == null)
            {
                return EmptyPage();
            }

            TableData<IRaritiesPage> page = new TableData<IRaritiesPage>()
            {
                TotalItems = result.Data!.Rarities!.TotalCount,
                Items = result.Data!.Rarities!.Items!
            };

            return page;
        }
    }
}
