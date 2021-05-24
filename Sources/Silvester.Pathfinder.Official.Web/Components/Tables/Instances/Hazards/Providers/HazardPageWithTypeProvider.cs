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
    public class HazardPageWithTypeProvider : GraphqlPageProvider<IHazardsPage, HazardSortInput>
    {
        private Guid HazardTypeId { get; }

        public HazardPageWithTypeProvider(IPathfinderOfficialApi api, Guid hazardTypeId)
            : base(api)
        {
            HazardTypeId = hazardTypeId;
        }

        public override async Task<TableData<IHazardsPage>> GetPage(HazardSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetHazardsWithTypePageResult>? result = await PathfinderOfficialApi.GetHazardsWithTypePage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, HazardTypeId, searchTerm, sortInputs);

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
