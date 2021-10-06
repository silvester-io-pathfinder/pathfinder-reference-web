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
    public class AncestryPageWithRarityProvider : GraphqlPageProvider<IAncestriesPage, AncestrySortInput>
    {
        private Guid AncestryRarityId { get; }

        public AncestryPageWithRarityProvider(IPathfinderReferenceApi api, Guid ancestryRarityId)
            : base(api)
        {
            AncestryRarityId = ancestryRarityId;
        }

        public override async Task<TableData<IAncestriesPage>> GetPage(AncestrySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAncestriesPageWithRarityResult> result = await PathfinderReferenceApi.GetAncestriesPageWithRarity
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, AncestryRarityId, searchTerm, sortInputs);

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
