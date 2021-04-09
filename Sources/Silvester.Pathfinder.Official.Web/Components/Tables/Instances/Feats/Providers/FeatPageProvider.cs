using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Feats.Providers
{
    public class FeatPageProvider : GraphqlPageProvider<IFeatsPage, FeatSortInput>
    {
        public FeatPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IFeatsPage>> GetPage(FeatSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetFeatsPageResult> result = await PathfinderOfficialApi.GetFeatsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Feats == null)
            {
                return EmptyPage();
            }

            TableData<IFeatsPage> page = new TableData<IFeatsPage>()
            {
                TotalItems = result.Data!.Feats!.TotalCount,
                Items = result.Data!.Feats!.Items!
            };

            return page;
        }
    }
}
