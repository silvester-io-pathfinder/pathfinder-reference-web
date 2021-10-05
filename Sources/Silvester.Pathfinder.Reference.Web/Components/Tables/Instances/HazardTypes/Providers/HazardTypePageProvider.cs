using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.HazardTypes.Providers
{
    public class HazardTypePageProvider : GraphqlPageProvider<IHazardTypesPage, HazardTypeSortInput>
    {
        public HazardTypePageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IHazardTypesPage>> GetPage(HazardTypeSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetHazardTypesPageResult> result = await PathfinderReferenceApi.GetHazardTypesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.HazardTypes == null)
            {
                return EmptyPage();
            }

            TableData<IHazardTypesPage> page = new TableData<IHazardTypesPage>()
            {
                TotalItems = result.Data!.HazardTypes!.TotalCount,
                Items = result.Data!.HazardTypes!.Items!
            };

            return page;
        }
    }
}
