﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Heritages.Providers
{
    public class HeritagePageWithRaceProvider : GraphqlPageProvider<IHeritagesPage, HeritageSortInput>
    {
        private Guid RaceId { get; }

        public HeritagePageWithRaceProvider(IPathfinderOfficialApi api, Guid raceId)
            : base(api)
        {
            RaceId = raceId;
        }

        public override async Task<TableData<IHeritagesPage>> GetPage(HeritageSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetHeritagesPageWithRaceResult> result = await PathfinderOfficialApi.GetHeritagesPageWithRace
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, RaceId, searchTerm, sortInputs);

            if (result.Data?.Heritages == null)
            {
                return EmptyPage();
            }

            TableData<IHeritagesPage> page = new TableData<IHeritagesPage>()
            {
                TotalItems = result.Data!.Heritages!.TotalCount,
                Items = result.Data!.Heritages!.Items!
            };

            return page;
        }
    }
}
