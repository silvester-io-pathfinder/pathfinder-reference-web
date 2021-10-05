using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Hazards.Providers
{
    public class HazardPageProvider : GraphqlPageProvider<IHazardsPage, HazardSortInput>
    {
        public HazardPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IHazardsPage>> GetPage(HazardSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetHazardsPageResult> result = await PathfinderOfficialApi.GetHazardsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Hazards == null)
            {
                return EmptyPage();
            }

            TableData<IHazardsPage> page = new TableData<IHazardsPage>()
            {
                TotalItems = result.Data!.Hazards!.TotalCount,
                Items = result.Data!.Hazards!.Items!
            };

            return page;
        }
    }
}
