using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.RangedWeapons.Providers
{
    public class RangedWeaponPageProvider : GraphqlPageProvider<IRangedWeaponsPage, RangedWeaponSortInput>
    {
        public RangedWeaponPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IRangedWeaponsPage>> GetPage(RangedWeaponSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetRangedWeaponsPageResult> result = await PathfinderOfficialApi.GetRangedWeaponsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.RangedWeapons == null)
            {
                return EmptyPage();
            }

            TableData<IRangedWeaponsPage> page = new TableData<IRangedWeaponsPage>()
            {
                TotalItems = result.Data!.RangedWeapons!.TotalCount,
                Items = result.Data!.RangedWeapons!.Items!
            };

            return page;
        }
    }
}
