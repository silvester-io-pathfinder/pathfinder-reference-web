using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.ArmorGroups.Providers
{
    public class ArmorGroupPageProvider : GraphqlPageProvider<IArmorGroupsPage, ArmorGroupSortInput>
    {
        public ArmorGroupPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IArmorGroupsPage>> GetPage(ArmorGroupSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetArmorGroupPageResult> result = await PathfinderOfficialApi.GetArmorGroupPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.ArmorGroups == null)
            {
                return EmptyPage();
            }

            TableData<IArmorGroupsPage> page = new TableData<IArmorGroupsPage>()
            {
                TotalItems = result.Data!.ArmorGroups!.TotalCount,
                Items = result.Data!.ArmorGroups!.Items!
            };

            return page;
        }
    }
}
