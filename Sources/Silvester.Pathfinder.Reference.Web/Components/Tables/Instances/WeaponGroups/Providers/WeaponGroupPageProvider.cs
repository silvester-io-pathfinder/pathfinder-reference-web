using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.WeaponGroups.Providers
{
    public class WeaponGroupPageProvider : GraphqlPageProvider<IWeaponGroupsPage, WeaponGroupSortInput>
    {
        public WeaponGroupPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IWeaponGroupsPage>> GetPage(WeaponGroupSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetWeaponGroupPageResult> result = await PathfinderReferenceApi.GetWeaponGroupPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.WeaponGroups == null)
            {
                return EmptyPage();
            }

            TableData<IWeaponGroupsPage> page = new TableData<IWeaponGroupsPage>()
            {
                TotalItems = result.Data!.WeaponGroups!.TotalCount,
                Items = result.Data!.WeaponGroups!.Items!
            };

            return page;
        }
    }
}
