using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.PreciousMaterials.Providers
{
    public class PreciousMaterialPageProvider : GraphqlPageProvider<IPreciousMaterialsPage, PreciousMaterialSortInput>
    {
        public PreciousMaterialPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IPreciousMaterialsPage>> GetPage(PreciousMaterialSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetPreciousMaterialsPageResult> result = await PathfinderOfficialApi.GetPreciousMaterialsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.PreciousMaterials == null)
            {
                return EmptyPage();
            }

            TableData<IPreciousMaterialsPage> page = new TableData<IPreciousMaterialsPage>()
            {
                TotalItems = result.Data!.PreciousMaterials!.TotalCount,
                Items = result.Data!.PreciousMaterials!.Items!
            };

            return page;
        }
    }
}
