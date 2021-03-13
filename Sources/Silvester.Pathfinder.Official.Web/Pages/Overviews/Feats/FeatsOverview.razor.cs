using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Mocked;
using Silvester.Pathfinder.Official.Web.Shared.Tables;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Overviews.Feats
{

    public partial class FeatsOverview : BaseOverviewPage
    {
        [Inject]
        public PathfinderOfficialApi PathfinderOfficialApi { get; set; } = default!;

        protected override string Title => "Feats";

        public void OnInspectClicked(IFeatsPage feat)
        {
            NavigationManager.NavigateTo($"/feats/{feat.Id}");
        }

        public async Task<TableData<IFeatsPage>> GetPage(TableState state, string? searchTerm)
        {
            Console.WriteLine("Getting page with sorting: " + state.SortLabel + " in direction " + state.SortDirection);

            FeatSortInput[] sortInputs = GetSortInput(state);

            Console.WriteLine("Getting page for sort input: " + JsonSerializer.Serialize(sortInputs));

            CancellationTokenSource timeout = new CancellationTokenSource(5000);
            IOperationResult<IGetFeatsPageResult> result = await PathfinderOfficialApi.GetFeatsPage
                .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm ?? "", sortInputs, timeout.Token);

            Console.WriteLine("Got page!");

            
            TableData<IFeatsPage> page = new TableData<IFeatsPage>()
            {
                TotalItems = result.Data!.Feats!.TotalCount,
                Items = result.Data!.Feats!.Items!
            };

            return page;
        }

        private static FeatSortInput[] GetSortInput(TableState state)
        {
            if (string.IsNullOrWhiteSpace(state.SortLabel))
            {
                return Array.Empty<FeatSortInput>();
            }

            SortEnumType? sortDirection = GetSortEnumTypeFromDirection(state);
            if(sortDirection == null)
            {
                return Array.Empty<FeatSortInput>();
            }

            FeatSortInput sortInput = new FeatSortInput();
            PropertyInfo sortProperty = typeof(FeatSortInput).GetProperty(state.SortLabel)!;
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
