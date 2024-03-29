﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Hazards.Providers
{
    public class HazardPageProvider : GraphqlPageProvider<IHazardsPage, HazardSortInput>
    {
        public HazardPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IHazardsPage>> GetPage(HazardSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetHazardsPageResult> result = await PathfinderReferenceApi.GetHazardsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Hazards == null)
            {
                return EmptyPage();
            }

            TableData<IHazardsPage> page = new TableData<IHazardsPage>()
            {
                TotalItems = result.Data!.Hazards!.TotalCount,
                Items = result.Data!.Hazards!.Items!
            };

            return page;
        }
    }
}
