using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Planes.Providers
{
    public class PlanePageWithCategoryProvider : GraphqlPageProvider<IPlanesPage, PlaneSortInput>
    {
        private Guid PlaneCategoryId { get; }

        public PlanePageWithCategoryProvider(IPathfinderReferenceApi api, Guid planeCategoryId)
            : base(api)
        {
            PlaneCategoryId = planeCategoryId;
        }

        public override async Task<TableData<IPlanesPage>> GetPage(PlaneSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetPlanesPageWithCategoryResult> result = await PathfinderReferenceApi.GetPlanesPageWithCategory
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, PlaneCategoryId, searchTerm, sortInputs);

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
