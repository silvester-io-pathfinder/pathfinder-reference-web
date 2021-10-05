using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using Silvester.Pathfinder.Reference.Web.Services;
using Silvester.Pathfinder.Reference.Web.Services.Currencies;
using Silvester.Pathfinder.Reference.Web.Shared.Tables;
using Silvester.Pathfinder.Reference.Web.Shared.Tables.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables
{
    public abstract partial class AbstractTable<TEntity, TSortInput> : ComponentBase
    {
        [Parameter]
        public string? Title { get; set; }

        [Parameter]
        public bool IsSearchEnabled { get; set; } = true;

        [Parameter]
        public IPageProvider<TEntity, TSortInput> PageProvider { get; set; } = default!;

        [Inject]
        public PathfinderReferenceApi PathfinderReferenceApi { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public IActionTypeService ActionTypeService { get; set; } = default!;

        [Inject]
        public ICurrencyService CurrencyService { get; set; } = default!;

        public TableModel<TEntity> Model { get; private set; } = default!;

        protected RenderFragment Table { get; private set; } = default!;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            TableBuilder<TEntity> builder = new TableBuilder<TEntity>(ActionTypeService, CurrencyService)
            {
                Title = Title,
                IsSearchEnabled = IsSearchEnabled
            };
            CreateModel(builder);
            Model = builder.Build();

            Table = tree =>
            {
                tree.OpenElement(1, "div");
                    tree.OpenComponent<GraphqlTable<TEntity, TSortInput>>(2);
                    tree.AddAttribute(2, "Model", Model);
                    tree.AddAttribute(2, "PageProvider", PageProvider);
                    tree.CloseComponent();
                tree.CloseElement();
            };
        }

        protected abstract void CreateModel(TableBuilder<TEntity> builder);
    }
}
