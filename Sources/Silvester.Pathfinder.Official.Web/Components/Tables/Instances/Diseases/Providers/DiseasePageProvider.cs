using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Diseases.Providers
{
    public class DiseasePageProvider : GraphqlPageProvider<IDiseasesPage, DiseaseSortInput>
    {
        public DiseasePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IDiseasesPage>> GetPage(DiseaseSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetDiseasesPageResult> result = await PathfinderOfficialApi.GetDiseasesPage
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
