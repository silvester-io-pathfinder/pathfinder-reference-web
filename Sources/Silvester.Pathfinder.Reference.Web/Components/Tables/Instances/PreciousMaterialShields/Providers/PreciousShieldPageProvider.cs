using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.PreciousMaterialShields.Providers
{
    public class PreciousMaterialShieldPageProvider : GraphqlPageProvider<IPreciousMaterialShieldsPage, PreciousMaterialShieldSortInput>
    {
        public PreciousMaterialShieldPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IPreciousMaterialShieldsPage>> GetPage(PreciousMaterialShieldSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetPreciousMaterialShieldsPageResult> result = await PathfinderReferenceApi.GetPreciousMaterialShieldsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.PreciousMaterialShields == null)
            {
                return EmptyPage();
            }

            TableData<IPreciousMaterialShieldsPage> page = new TableData<IPreciousMaterialShieldsPage>()
            {
                TotalItems = result.Data!.PreciousMaterialShields!.TotalCount,
                Items = result.Data!.PreciousMaterialShields!.Items!
            };

            return page;
        }
    }
}
