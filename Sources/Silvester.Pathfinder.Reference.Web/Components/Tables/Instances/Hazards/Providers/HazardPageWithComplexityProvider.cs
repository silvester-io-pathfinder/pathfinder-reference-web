using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Hazards.Providers
{
    public class HazardPageWithComplexityProvider : GraphqlPageProvider<IHazardsPage, HazardSortInput>
    {
        private Guid HazardComplexityId { get; }

        public HazardPageWithComplexityProvider(IPathfinderReferenceApi api, Guid hazardComplexityId)
            : base(api)
        {
            HazardComplexityId = hazardComplexityId;
        }

        public override async Task<TableData<IHazardsPage>> GetPage(HazardSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetHazardsWithComplexityPageResult> result = await PathfinderReferenceApi.GetHazardsWithComplexityPage
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
