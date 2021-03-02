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
        protected IDispatcher? Dispatcher { get; set; }

        protected virtual IReadOnlyList<string> GetTitleComponents()
        {
            return Array.Empty<string>();
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            List<string> components = new List<string>() { "Silvester Pathfinder" };
            components.AddRange(GetTitleComponents());

            Dispatcher!.Dispatch(new SetPageTitleAction(components));
        }
    }
}
