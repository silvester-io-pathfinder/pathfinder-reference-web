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
    public class RacePageProvider : GraphqlPageProvider<IRacesPage, RaceSortInput>
    {
        public RacePageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IRacesPage>> GetPage(RaceSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetRacesPageResult> result = await PathfinderReferenceApi.GetRacesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

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
