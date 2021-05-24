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
    public class HazardPageWithComplexityProvider : GraphqlPageProvider<IHazardsPage, HazardSortInput>
    {
        private Guid HazardComplexityId { get; }

        public HazardPageWithComplexityProvider(IPathfinderOfficialApi api, Guid hazardComplexityId)
            : base(api)
        {
            HazardComplexityId = hazardComplexityId;
        }

        public override async Task<TableData<IHazardsPage>> GetPage(HazardSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetHazardsWithComplexityPageResult> result = await PathfinderOfficialApi.GetHazardsWithComplexityPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, HazardComplexityId, searchTerm, sortInputs);

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
