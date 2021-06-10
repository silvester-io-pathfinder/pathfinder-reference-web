using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.MeleeWeapons.Providers
{
    public class MeleeWeaponPageWithGroupProvider : GraphqlPageProvider<IMeleeWeaponsPage, MeleeWeaponSortInput>
    {
        private Guid WeaponGroupId { get; }

        public MeleeWeaponPageWithGroupProvider(IPathfinderOfficialApi api, Guid weaponGroupId)
            : base(api)
        {
            WeaponGroupId = weaponGroupId;
        }

        public override async Task<TableData<IMeleeWeaponsPage>> GetPage(MeleeWeaponSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetMeleeWeaponPageWithGroupResult> result = await PathfinderOfficialApi.GetMeleeWeaponPageWithGroup
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, WeaponGroupId, searchTerm, sortInputs);

            if (result.Data?.MeleeWeapons == null)
            {
                return EmptyPage();
            }

            TableData<IMeleeWeaponsPage> page = new TableData<IMeleeWeaponsPage>()
            {
                TotalItems = result.Data!.MeleeWeapons!.TotalCount,
                Items = result.Data!.MeleeWeapons!.Items!
            };

            return page;
        }
    }
}
