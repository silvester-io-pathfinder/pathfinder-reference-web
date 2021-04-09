using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Deities.Providers
{
    public class DeityPageWithAlignmentProvider : GraphqlPageProvider<IDeitiesPage, DeitySortInput>
    {
        private Guid AlignmentId { get; }

        public DeityPageWithAlignmentProvider(IPathfinderOfficialApi api, Guid alignmentId)
            : base(api)
        {
            AlignmentId = alignmentId;
        }

        public override async Task<TableData<IDeitiesPage>> GetPage(DeitySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetDeitiesPageWithAlignmentResult> result = await PathfinderOfficialApi.GetDeitiesPageWithAlignment
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, AlignmentId, searchTerm, sortInputs);

            if (result.Data?.Deities == null)
            {
                return EmptyPage();
            }

            TableData<IDeitiesPage> page = new TableData<IDeitiesPage>()
            {
                TotalItems = result.Data!.Deities!.TotalCount,
                Items = result.Data!.Deities!.Items!
            };

            return page;
        }
    }
}
