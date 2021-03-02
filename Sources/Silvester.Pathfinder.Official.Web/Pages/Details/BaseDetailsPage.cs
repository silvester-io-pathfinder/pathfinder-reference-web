using Fluxor;
using Microsoft.AspNetCore.Components;
using Silvester.Pathfinder.Official.Web.Store.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Details
{
    public abstract class BaseDetailsPage : BasePage
    {
        protected abstract string Title { get; }

        protected override IReadOnlyList<string> GetTitleComponents()
        {
            return new[] { Title };
        }
    }
}
