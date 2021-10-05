using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Spells.Providers
{
    public class SpellPageWithComponentProvider : GraphqlPageProvider<ISpellsPage, SpellSortInput>
    {
        private Guid MagicComponentId { get; }

        public SpellPageWithComponentProvider(IPathfinderReferenceApi api, Guid magicComponentId)
            : base(api)
        {
            MagicComponentId = magicComponentId;
        }

        public override async Task<TableData<ISpellsPage>> GetPage(SpellSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetSpellsPageWithComponentResult> result = await PathfinderReferenceApi.GetSpellsPageWithComponent
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, MagicComponentId, searchTerm, sortInputs);

            if (result?.Data?.Spells == null)
            {
                return EmptyPage();
            }

            TableData<ISpellsPage> page = new TableData<ISpellsPage>()
            {
                TotalItems = result.Data!.Spells!.TotalCount,
                Items = result.Data!.Spells!.Items!
            };

            return page;
        }
    }
}
