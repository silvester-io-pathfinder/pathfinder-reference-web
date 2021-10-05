using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Alignments.Providers
{
    public class AlignmentPageProvider : GraphqlPageProvider<IAlignmentsPage, AlignmentSortInput>
    {
        public AlignmentPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IAlignmentsPage>> GetPage(AlignmentSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAlignmentsPageResult> result = await PathfinderOfficialApi.GetAlignmentsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Alignments == null)
            {
                return EmptyPage();
            }

            TableData<IAlignmentsPage> page = new TableData<IAlignmentsPage>()
            {
                TotalItems = result.Data!.Alignments!.TotalCount,
                Items = result.Data!.Alignments!.Items!
            };

            return page;
        }
    }
}
