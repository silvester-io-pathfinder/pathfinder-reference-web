using Fluxor;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Store.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Overviews
{
    public abstract class BaseDetailPage : BaseOverviewPage
    {
        protected abstract string? Subtitle { get; }

        protected override IReadOnlyList<string> GetTitleComponents()
        {
            return new[] { Title, Subtitle };
        }
    }
}
