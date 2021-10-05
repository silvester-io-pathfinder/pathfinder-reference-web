﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.ArmorPropertyRunes.Providers
{
    public class ArmorPropertyRunePageProvider : GraphqlPageProvider<IArmorPropertyRunesPage, ArmorPropertyRuneSortInput>
    {
        public ArmorPropertyRunePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IArmorPropertyRunesPage>> GetPage(ArmorPropertyRuneSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetArmorPropertyRunesPageResult> result = await PathfinderOfficialApi.GetArmorPropertyRunesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.ArmorPropertyRunes == null)
            {
                return EmptyPage();
            }

            TableData<IArmorPropertyRunesPage> page = new TableData<IArmorPropertyRunesPage>()
            {
                TotalItems = result.Data!.ArmorPropertyRunes!.TotalCount,
                Items = result.Data!.ArmorPropertyRunes!.Items!
            };

            return page;
        }
    }
}
