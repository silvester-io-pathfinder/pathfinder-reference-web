﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Armors.Providers
{
    public class ArmorPageProvider : GraphqlPageProvider<IArmorsPage, ArmorSortInput>
    {
        public ArmorPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IArmorsPage>> GetPage(ArmorSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetArmorsPageResult> result = await PathfinderOfficialApi.GetArmorsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.Armors == null)
            {
                return EmptyPage();
            }

            TableData<IArmorsPage> page = new TableData<IArmorsPage>()
            {
                TotalItems = result.Data!.Armors!.TotalCount,
                Items = result.Data!.Armors!.Items!
            };

            return page;
        }
    }
}
