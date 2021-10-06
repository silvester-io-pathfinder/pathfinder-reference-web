using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Ancestries.Providers
{
    public class AncestryPageProvider : GraphqlPageProvider<IAncestriesPage, AncestrySortInput>
    {
        public AncestryPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IAncestriesPage>> GetPage(AncestrySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAncestriesPageResult> result = await PathfinderReferenceApi.GetAncestriesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.Ancestries == null)
            {
                return EmptyPage();
            }

            TableData<IAncestriesPage> page = new TableData<IAncestriesPage>()
            {
                TotalItems = result.Data!.Ancestries!.TotalCount,
                Items = result.Data!.Ancestries!.Items!
            };

            return page;
        }
    }
}
