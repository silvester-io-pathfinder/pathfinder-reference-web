using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.FundamentalArmorRunes.Providers
{
    public class FundamentalArmorRunePageProvider : GraphqlPageProvider<IFundamentalArmorRunesPage, FundamentalArmorRuneSortInput>
    {
        public FundamentalArmorRunePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IFundamentalArmorRunesPage>> GetPage(FundamentalArmorRuneSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetFundamentalArmorRunesPageResult> result = await PathfinderOfficialApi.GetFundamentalArmorRunesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.FundamentalArmorRunes == null)
            {
                return EmptyPage();
            }

            TableData<IFundamentalArmorRunesPage> page = new TableData<IFundamentalArmorRunesPage>()
            {
                TotalItems = result.Data!.FundamentalArmorRunes!.TotalCount,
                Items = result.Data!.FundamentalArmorRunes!.Items!
            };

            return page;
        }
    }
}
