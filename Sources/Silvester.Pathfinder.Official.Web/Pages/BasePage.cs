using Fluxor;
using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Official.Web.Store.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages
{
    public class BasePage : ComponentBase
    {
        [Inject]
        protected IDispatcher Dispatcher { get; set; } = default!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        protected virtual IReadOnlyList<string> GetTitleComponents()
        {
            return Array.Empty<string>();
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            OnTitleChanged();
        }

        protected virtual void OnTitleChanged()
        {
            List<string> components = new List<string>() { "Silvester Pathfinder" };
            components.AddRange(GetTitleComponents());

            Dispatcher.Dispatch(new SetPageTitleAction(components.Where(e => e != null).ToList()));
        }
    }
}
