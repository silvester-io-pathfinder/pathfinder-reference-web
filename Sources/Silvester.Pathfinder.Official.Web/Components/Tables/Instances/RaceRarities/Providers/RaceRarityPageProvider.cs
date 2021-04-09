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
    public class RaceRarityPageProvider : GraphqlPageProvider<IRaceRaritiesPage, RaceRaritySortInput>
    {
        public RaceRarityPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IRaceRaritiesPage>> GetPage(RaceRaritySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetRaceRaritiesPageResult> result = await PathfinderOfficialApi.GetRaceRaritiesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.RaceRarities == null)
            {
                return EmptyPage();
            }

            TableData<IRaceRaritiesPage> page = new TableData<IRaceRaritiesPage>()
            {
                TotalItems = result.Data!.RaceRarities!.TotalCount,
                Items = result.Data!.RaceRarities!.Items!
            };

            return page;
        }
    }
}
