﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.PreciousMaterialArmors.Providers
{
    public class PreciousMaterialArmorPageProvider : GraphqlPageProvider<IPreciousMaterialArmorsPage, PreciousMaterialArmorSortInput>
    {
        public PreciousMaterialArmorPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IPreciousMaterialArmorsPage>> GetPage(PreciousMaterialArmorSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetPreciousMaterialArmorsPageResult> result = await PathfinderReferenceApi.GetPreciousMaterialArmorsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.PreciousMaterialArmors == null)
            {
                return EmptyPage();
            }

            TableData<IPreciousMaterialArmorsPage> page = new TableData<IPreciousMaterialArmorsPage>()
            {
                TotalItems = result.Data!.PreciousMaterialArmors!.TotalCount,
                Items = result.Data!.PreciousMaterialArmors!.Items!
            };

            return page;
        }
    }
}
