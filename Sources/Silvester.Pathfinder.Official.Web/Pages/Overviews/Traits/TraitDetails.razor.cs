using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Services;
using System;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Overviews.Traits
{
    public partial class TraitDetails : BaseDetailPage, IDisposable
    {
        protected override string Title => "Traits";

        protected override string? Subtitle => Trait?.Name;

        [Inject]
        public IClipboardService ClipboardService { get; set; } = default!;

        [Parameter]
        public Guid TraitId { get; set; }

        [Inject]
        public PathfinderOfficialApi PathfinderOfficialApi { get; set; } = default!;

        [Inject]
        public ISnackbar Snackbar { get; set; } = default!;

        public string? FeatSearchString { get; set; }

        public ITraitById? Trait { get; set; }

        private IDisposable? StoreSession {get;set;}

        protected override void OnInitialized()
        {
            StoreSession = PathfinderOfficialApi.GetTraitById
                .Watch(TraitId, StrawberryShake.ExecutionStrategy.CacheFirst)
                .Select(e => e.Data?.Traits?.Items?.FirstOrDefault())
                .Subscribe(trait => 
                {
                    Trait = trait;
                    StateHasChanged();
                });
        }

        public async Task OnShareClickAsync()
        {
            await ClipboardService.WriteTextAsync(NavigationManager.Uri);
            Snackbar.Add(@"Copied URL to clipboard!", Severity.Success);
        }

        public void OnInspectFeatClicked(ITraitById_Feat feat)
        {
            NavigationManager.NavigateTo($"/feats/{feat.Id}");
        }

        public void OnFeatSearch(string? featSearchString)
        {
            FeatSearchString = featSearchString?.ToLower();
        }

        public bool FeatsFilter(ITraitById_Feat feat)
        {
            if(string.IsNullOrWhiteSpace(FeatSearchString))
            {
                return true;
            }

            return feat.Name.ToLower().Contains(FeatSearchString);
        }

        public void Dispose()
        {
            StoreSession?.Dispose();
        }
    }
}
