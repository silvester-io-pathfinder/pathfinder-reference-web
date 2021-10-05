using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.AdventuringGears.Providers
{
    public class AdventuringGearPageProvider : GraphqlPageProvider<IAdventuringGearsPage, AdventuringGearSortInput>
    {
        public AdventuringGearPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IAdventuringGearsPage>> GetPage(AdventuringGearSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAdventuringGearsPageResult> result = await PathfinderReferenceApi.GetAdventuringGearsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.AdventuringGears == null)
            {
                return EmptyPage();
            }

            TableData<IAdventuringGearsPage> page = new TableData<IAdventuringGearsPage>()
            {
                TotalItems = result.Data!.AdventuringGears!.TotalCount,
                Items = result.Data!.AdventuringGears!.Items!
            };

            return page;
        }
    }
}
