using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.HazardComplexities.Providers
{
    public class HazardComplexityPageProvider : GraphqlPageProvider<IHazardComplexitiesPage, HazardComplexitySortInput>
    {
        public HazardComplexityPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IHazardComplexitiesPage>> GetPage(HazardComplexitySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetHazardComplexitiesPageResult> result = await PathfinderReferenceApi.GetHazardComplexitiesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.HazardComplexities == null)
            {
                return EmptyPage();
            }

            TableData<IHazardComplexitiesPage> page = new TableData<IHazardComplexitiesPage>()
            {
                TotalItems = result.Data!.HazardComplexities!.TotalCount,
                Items = result.Data!.HazardComplexities!.Items!
            };

            return page;
        }
    }
}
