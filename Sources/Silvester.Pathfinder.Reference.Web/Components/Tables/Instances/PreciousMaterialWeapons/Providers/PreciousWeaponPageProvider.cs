using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.PreciousMaterialWeapons.Providers
{
    public class PreciousMaterialWeaponPageProvider : GraphqlPageProvider<IPreciousMaterialWeaponsPage, PreciousMaterialWeaponSortInput>
    {
        public PreciousMaterialWeaponPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IPreciousMaterialWeaponsPage>> GetPage(PreciousMaterialWeaponSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetPreciousMaterialWeaponsPageResult> result = await PathfinderReferenceApi.GetPreciousMaterialWeaponsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.PreciousMaterialWeapons == null)
            {
                return EmptyPage();
            }

            TableData<IPreciousMaterialWeaponsPage> page = new TableData<IPreciousMaterialWeaponsPage>()
            {
                TotalItems = result.Data!.PreciousMaterialWeapons!.TotalCount,
                Items = result.Data!.PreciousMaterialWeapons!.Items!
            };

            return page;
        }
    }
}
