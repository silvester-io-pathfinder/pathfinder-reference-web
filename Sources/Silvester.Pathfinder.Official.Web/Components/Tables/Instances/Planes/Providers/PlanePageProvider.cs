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
    public class PlanePageProvider : GraphqlPageProvider<IPlanesPage, PlaneSortInput>
    {
        public PlanePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IPlanesPage>> GetPage(PlaneSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetPlanesPageResult> result = await PathfinderOfficialApi.GetPlanesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if(result.Data?.Planes == null)
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
