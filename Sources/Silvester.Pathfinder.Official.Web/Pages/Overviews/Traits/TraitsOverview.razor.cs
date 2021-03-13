using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Overviews.Traits
{
    public partial class TraitsOverview : BaseOverviewPage
    {
        [Inject]
        public PathfinderOfficialApi PathfinderOfficialApi { get; set; } = default!;

        protected override string Title => "Traits";

        public void OnInspectClicked(ITraitsPage trait)
        {
            NavigationManager.NavigateTo($"/traits/{trait.Id}");
        }

        public async Task<TableData<ITraitsPage>> GetPage(TableState state, string? searchTerm)
        {
            TraitSortInput[] sortInputs = GetSortInput(state);

            CancellationTokenSource timeout = new CancellationTokenSource(5000);
            IOperationResult<IGetTraitsPageResult> result = await PathfinderOfficialApi.GetTraitsPage
                .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm ?? "", sortInputs, timeout.Token);

            TableData<ITraitsPage> page = new TableData<ITraitsPage>()
            {
                TotalItems = result.Data!.Traits!.TotalCount,
                Items = result.Data!.Traits!.Items!
            };

            return page;
        }

        private static TraitSortInput[] GetSortInput(TableState state)
        {
            if (string.IsNullOrWhiteSpace(state.SortLabel))
            {
                return Array.Empty<TraitSortInput>();
            }

            SortEnumType? sortDirection = GetSortEnumTypeFromDirection(state);
            if (sortDirection == null)
            {
                return Array.Empty<TraitSortInput>();
            }

            TraitSortInput sortInput = new TraitSortInput();
            PropertyInfo sortProperty = typeof(TraitSortInput).GetProperty(state.SortLabel)!;
            sortProperty.SetValue(sortInput, sortDirection);

            return new[] { sortInput };
        }

        private static SortEnumType? GetSortEnumTypeFromDirection(TableState state)
        {
            return state.SortDirection switch
            {
                SortDirection.Ascending => SortEnumType.Asc,
                SortDirection.Descending => SortEnumType.Desc,
                _ => null
            };
        }
    }
}
