using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Traits.Providers
{
    public class TraitPageProvider : GraphqlPageProvider<ITraitsPage, TraitSortInput>
    {
        public TraitPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<ITraitsPage>> GetPage(TraitSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetTraitsPageResult> result = await PathfinderReferenceApi.GetTraitsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if(result?.Data?.Traits == null)
            {
                return EmptyPage();
            }

            TableData<ITraitsPage> page = new TableData<ITraitsPage>()
            {
                TotalItems = result.Data!.Traits!.TotalCount,
                Items = result.Data!.Traits!.Items!
            };

            return page;
        }
    }
}
