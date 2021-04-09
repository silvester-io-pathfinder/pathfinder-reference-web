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
    public class SpellPageWithTraditionProvider : GraphqlPageProvider<ISpellsPage, SpellSortInput>
    {
        private Guid MagicTraditionId { get; }

        public SpellPageWithTraditionProvider(IPathfinderOfficialApi api, Guid magicTraditionId)
            : base(api)
        {
            MagicTraditionId = magicTraditionId;
        }

        public override async Task<TableData<ISpellsPage>> GetPage(SpellSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetSpellsPageWithTraditionResult> result = await PathfinderOfficialApi.GetSpellsPageWithTradition
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, MagicTraditionId, searchTerm, sortInputs);

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
