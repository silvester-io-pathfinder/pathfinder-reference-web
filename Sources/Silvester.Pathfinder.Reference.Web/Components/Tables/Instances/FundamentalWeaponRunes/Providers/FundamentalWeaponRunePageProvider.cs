using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.FundamentalWeaponRunes.Providers
{
    public class FundamentalWeaponRunePageProvider : GraphqlPageProvider<IFundamentalWeaponRunesPage, FundamentalWeaponRuneSortInput>
    {
        public FundamentalWeaponRunePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IFundamentalWeaponRunesPage>> GetPage(FundamentalWeaponRuneSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetFundamentalWeaponRunesPageResult> result = await PathfinderOfficialApi.GetFundamentalWeaponRunesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.FundamentalWeaponRunes == null)
            {
                return EmptyPage();
            }

            TableData<IFundamentalWeaponRunesPage> page = new TableData<IFundamentalWeaponRunesPage>()
            {
                TotalItems = result.Data!.FundamentalWeaponRunes!.TotalCount,
                Items = result.Data!.FundamentalWeaponRunes!.Items!
            };

            return page;
        }
    }
}
