using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Shared.Cards
{
    public partial class ComponentDetailsCard<TEntity>
    {
        [Inject]
        public IClipboardService ClipboardService { get; set; } = default!;
        
        [Inject]
        public ISnackbar Snackbar { get; set; } = default!;

        [Parameter]
        public TEntity? Entity { get; set; }

        [Parameter]
        public RenderFragment<TEntity> Actions { get; set; } = default!;

        [Parameter]
        public RenderFragment<TEntity> LeftContent { get; set; } = default!;

        [Parameter]
        public RenderFragment<TEntity> RightContent { get; set; } = default!;

        [Parameter]
        public RenderFragment<TEntity> Title { get; set; } = default!;
    }
}
