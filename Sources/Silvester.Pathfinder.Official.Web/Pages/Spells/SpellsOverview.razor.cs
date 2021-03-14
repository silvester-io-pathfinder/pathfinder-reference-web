using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Overviews.Spells
{
    public partial class SpellsOverview : BaseOverviewPage
    {
        protected override string Title => "Spells";

        [Inject]
        public PathfinderOfficialApi PathfinderOfficialApi { get; set; }

        public async Task<TableData<IGetSpellsPage_Spells_Items>> GetPage(TableState state, string? searchTerm)
        {
            SpellSortInput[] sortInputs = GetSortInput(state);

            IOperationResult<IGetSpellsPageResult> result = await PathfinderOfficialApi.GetSpellsPage
                .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm ?? "", sortInputs);

            TableData<IGetSpellsPage_Spells_Items> page = new TableData<IGetSpellsPage_Spells_Items>()
            {
                TotalItems = result.Data!.Spells!.TotalCount,
                Items = result.Data!.Spells!.Items!
            };

            return page;
        }

        private static SpellSortInput[] GetSortInput(TableState state)
        {
            if (string.IsNullOrWhiteSpace(state.SortLabel))
            {
                return Array.Empty<SpellSortInput>();
            }
            SortEnumType sortDirection = state.SortDirection == SortDirection.Ascending ? SortEnumType.Asc : SortEnumType.Desc;
            SpellSortInput sortInput = new SpellSortInput();

            PropertyInfo sortProperty = typeof(SpellSortInput).GetProperty(state.SortLabel)!;
            sortProperty.SetValue(sortInput, sortDirection);

            return new[] { sortInput };
        }
    }
}
