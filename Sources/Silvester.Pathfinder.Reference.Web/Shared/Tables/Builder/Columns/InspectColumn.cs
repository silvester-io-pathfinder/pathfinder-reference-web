using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Silvester.Pathfinder.Reference.Web.Shared.Tables.Builder.Columns
{
    public class InspectColumn<TEntity> : ActionColumn<TEntity>
    {
        public InspectColumn(NavigationManager navigationManager, Func<TEntity, string> redirect, bool hasDenseRightPadding)
            : base ((e) => navigationManager.NavigateTo(redirect(e)), "", "Inspect", MudBlazor.Icons.Material.Outlined.ArrowForward, Size.Small, hasDenseRightPadding)
        {
          
        }
    }
}
