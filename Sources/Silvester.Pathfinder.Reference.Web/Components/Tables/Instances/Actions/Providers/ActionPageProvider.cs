using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Actions.Providers
{
    public class ActionPageProvider : GraphqlPageProvider<IActionsPage, ActionSortInput>
    {
        public ActionPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IActionsPage>> GetPage(ActionSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetActionsPageResult> result = await PathfinderOfficialApi.GetActionsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Actions == null)
            {
                return EmptyPage();
            }

            TableData<IActionsPage> page = new TableData<IActionsPage>()
            {
                TotalItems = result.Data!.Actions!.TotalCount,
                Items = result.Data!.Actions!.Items!
            };

            return page;
        }
    }
}
