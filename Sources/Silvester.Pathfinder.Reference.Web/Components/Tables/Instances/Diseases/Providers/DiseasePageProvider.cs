using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Diseases.Providers
{
    public class DiseasePageProvider : GraphqlPageProvider<IDiseasesPage, DiseaseSortInput>
    {
        public DiseasePageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IDiseasesPage>> GetPage(DiseaseSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetDiseasesPageResult> result = await PathfinderReferenceApi.GetDiseasesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Diseases == null)
            {
                return EmptyPage();
            }

            TableData<IDiseasesPage> page = new TableData<IDiseasesPage>()
            {
                TotalItems = result.Data!.Diseases!.TotalCount,
                Items = result.Data!.Diseases!.Items!
            };

            return page;
        }
    }
}
