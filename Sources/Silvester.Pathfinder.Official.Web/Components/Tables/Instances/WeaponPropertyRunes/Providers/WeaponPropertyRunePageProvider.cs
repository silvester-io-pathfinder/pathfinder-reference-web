using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.WeaponPropertyRunes.Providers
{
    public class WeaponPropertyRunePageProvider : GraphqlPageProvider<IWeaponPropertyRunesPage, WeaponPropertyRuneSortInput>
    {
        public WeaponPropertyRunePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IWeaponPropertyRunesPage>> GetPage(WeaponPropertyRuneSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetWeaponPropertyRunesPageResult> result = await PathfinderOfficialApi.GetWeaponPropertyRunesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.WeaponPropertyRunes == null)
            {
                return EmptyPage();
            }

            TableData<IWeaponPropertyRunesPage> page = new TableData<IWeaponPropertyRunesPage>()
            {
                TotalItems = result.Data!.WeaponPropertyRunes!.TotalCount,
                Items = result.Data!.WeaponPropertyRunes!.Items!
            };

            return page;
        }
    }
}
