using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Races.Providers
{
    public class RacePageWithRarityProvider : GraphqlPageProvider<IRacesPage, RaceSortInput>
    {
        private Guid RaceRarityId { get; }

        public RacePageWithRarityProvider(IPathfinderReferenceApi api, Guid raceRarityId)
            : base(api)
        {
            RaceRarityId = raceRarityId;
        }

        public override async Task<TableData<IRacesPage>> GetPage(RaceSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetRacesPageWithRarityResult> result = await PathfinderReferenceApi.GetRacesPageWithRarity
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, RaceRarityId, searchTerm, sortInputs);

            if (result?.Data?.Races == null)
            {
                return EmptyPage();
            }

            TableData<IRacesPage> page = new TableData<IRacesPage>()
            {
                TotalItems = result.Data!.Races!.TotalCount,
                Items = result.Data!.Races!.Items!
            };

            return page;
        }
    }
}
