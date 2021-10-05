using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Mysteries.Providers 
{
    public class MysteryPageProvider : GraphqlPageProvider<IMysteriesPage, MysterySortInput>
    {
        public MysteryPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IMysteriesPage>> GetPage(MysterySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetMysteriesPageResult> result = await PathfinderReferenceApi.GetMysteriesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.Mysteries == null)
            {
                return EmptyPage();
            }

            TableData<IMysteriesPage> page = new TableData<IMysteriesPage>()
            {
                TotalItems = result.Data!.Mysteries!.TotalCount,
                Items = result.Data!.Mysteries!.Items!
            };

            return page;
        }
    }
}
