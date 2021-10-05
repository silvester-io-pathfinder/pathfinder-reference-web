﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.AlchemicalPoisons.Providers
{
    public class AlchemicalPoisonPageProvider : GraphqlPageProvider<IAlchemicalPoisonsPage, AlchemicalPoisonSortInput>
    {
        public AlchemicalPoisonPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IAlchemicalPoisonsPage>> GetPage(AlchemicalPoisonSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAlchemicalPoisonsPageResult>? result = await PathfinderOfficialApi.GetAlchemicalPoisonsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.AlchemicalPoisons == null)
            {
                return EmptyPage();
            }

            TableData<IAlchemicalPoisonsPage> page = new TableData<IAlchemicalPoisonsPage>()
            {
                TotalItems = result.Data!.AlchemicalPoisons!.TotalCount,
                Items = result.Data!.AlchemicalPoisons!.Items!
            };

            return page;
        }
    }
}
