using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Mocked;
using Silvester.Pathfinder.Official.Web.Services;
using Silvester.Pathfinder.Official.Web.Shared.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Silvester.Pathfinder.Official.Web.Shared.Preferences;

namespace Silvester.Pathfinder.Official.Web.Pages.Overviews.Feats
{
    public partial class FeatDetails : BaseDetailPage, IDisposable
    {
        protected override string Title => "Feats";

        protected override string? Subtitle => Feat?.Name;

        [Inject]
        public IClipboardService ClipboardService { get; set; } = default!;

        [Parameter]
        public Guid FeatId { get; set; }

        [Inject]
        public PathfinderOfficialApi PathfinderOfficialApi { get; set; } = default!;

        [Inject]
        public ISnackbar Snackbar { get; set; } = default!;

        public IFeatById? Feat { get; set; }

        private IDisposable? StoreSession {get;set;}

        protected override void OnInitialized()
        {
            StoreSession = PathfinderOfficialApi.GetFeatById
                .Watch(FeatId, StrawberryShake.ExecutionStrategy.CacheFirst)
                .Select(e => e.Data?.Feats?.Items?.FirstOrDefault())
                .Subscribe(feat => 
                {
                    Feat = feat;
                    StateHasChanged();
                });
        }

        public async Task OnShareClickAsync()
        {
            await ClipboardService.WriteTextAsync(NavigationManager.Uri);
            Snackbar.Add(@"Copied URL to clipboard!", Severity.Success);
        }
        
        public void OnTraitClick(IFeatById_Trait trait)
        {
            NavigationManager.NavigateTo($"/traits/{trait.Id}");
        }

        public void Dispose()
        {
            StoreSession?.Dispose();
        }
    }
}
