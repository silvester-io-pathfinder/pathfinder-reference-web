using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Planes.Providers
{
    public class PlanePageWithAlignmentProvider : GraphqlPageProvider<IPlanesPage, PlaneSortInput>
    {
        private Guid AlignmentId { get; }

        public PlanePageWithAlignmentProvider(IPathfinderOfficialApi api, Guid alignmentId)
            : base(api)
        {
            AlignmentId = alignmentId;
        }

        public override async Task<TableData<IPlanesPage>> GetPage(PlaneSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetPlanesPageWithAlignmentResult> result = await PathfinderOfficialApi.GetPlanesPageWithAlignment
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, AlignmentId, searchTerm, sortInputs);

            if (result.Data?.Planes == null)
            {
                return EmptyPage();
            }

            TableData<IPlanesPage> page = new TableData<IPlanesPage>()
            {
                TotalItems = result.Data!.Planes!.TotalCount,
                Items = result.Data!.Planes!.Items!
            };

            return page;
        }
    }
}
