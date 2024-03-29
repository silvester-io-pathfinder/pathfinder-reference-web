﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Shields.Providers
{
    public class ShieldPageProvider : GraphqlPageProvider<IShieldsPage, ShieldSortInput>
    {
        public ShieldPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IShieldsPage>> GetPage(ShieldSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetShieldsPageResult> result = await PathfinderReferenceApi.GetShieldsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.Shields == null)
            {
                return EmptyPage();
            }

            TableData<IShieldsPage> page = new TableData<IShieldsPage>()
            {
                TotalItems = result.Data!.Shields!.TotalCount,
                Items = result.Data!.Shields!.Items!
            };

            return page;
        }
    }
}
