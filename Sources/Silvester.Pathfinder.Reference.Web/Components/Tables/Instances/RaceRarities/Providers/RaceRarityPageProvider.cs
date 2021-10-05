using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.RaceRarities.Providers
{
    public class RaceRarityPageProvider : GraphqlPageProvider<IRaritiesPage, RaritySortInput>
    {
        public RaceRarityPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IRaritiesPage>> GetPage(RaritySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetRaritiesPageResult> result = await PathfinderOfficialApi.GetRaritiesPage
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
