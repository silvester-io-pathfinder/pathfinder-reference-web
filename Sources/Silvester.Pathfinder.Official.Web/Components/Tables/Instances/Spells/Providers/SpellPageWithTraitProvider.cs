using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Spells.Providers
{
    public class SpellPageWithTraitProvider : GraphqlPageProvider<ISpellsPage, SpellSortInput>
    {
        private Guid TraitId { get; }

        public SpellPageWithTraitProvider(IPathfinderOfficialApi api, Guid traitId)
            : base(api)
        {
            TraitId = traitId;
        }

        public override async Task<TableData<ISpellsPage>> GetPage(SpellSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetSpellsPageWithTraitResult> result = await PathfinderOfficialApi.GetSpellsPageWithTrait
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, TraitId, searchTerm, sortInputs);

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
