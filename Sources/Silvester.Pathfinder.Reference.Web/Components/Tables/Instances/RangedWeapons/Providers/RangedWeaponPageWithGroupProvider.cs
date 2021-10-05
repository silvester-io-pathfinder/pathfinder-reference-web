using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.RangedWeapons.Providers
{
    public class RangedWeaponPageWithGroupProvider : GraphqlPageProvider<IRangedWeaponsPage, RangedWeaponSortInput>
    {
        private Guid WeaponGroupId { get; }

        public RangedWeaponPageWithGroupProvider(IPathfinderReferenceApi api, Guid weaponGroupId)
            : base(api)
        {
            WeaponGroupId = weaponGroupId;
        }

        public override async Task<TableData<IRangedWeaponsPage>> GetPage(RangedWeaponSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetRangedWeaponPageWithGroupResult> result = await PathfinderReferenceApi.GetRangedWeaponPageWithGroup
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, WeaponGroupId, searchTerm, sortInputs);

            if (result.Data?.RangedWeapons == null)
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
