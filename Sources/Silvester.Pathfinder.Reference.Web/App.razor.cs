
using Fluxor;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Store.States;
using Silvester.Pathfinder.Reference.Web.Themes;
using System;

namespace Silvester.Pathfinder.Reference.Web
{
    public partial class App : IDisposable
    {
        [Inject]
        public IThemeProvider ThemeProvider { get; set; } = default!;

        protected override void OnInitialized()
        {
            ThemeProvider.StateChanged += OnStateChange;
        }

        private void OnStateChange()
        {
            StateHasChanged();
        }

        public void Dispose()
        {
            if(ThemeProvider != null)
            {
                ThemeProvider.StateChanged -= OnStateChange;
            }
        }
    }
}
