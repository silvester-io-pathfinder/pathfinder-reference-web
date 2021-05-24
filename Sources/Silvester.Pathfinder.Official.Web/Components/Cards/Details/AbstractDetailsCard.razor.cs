using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using Silvester.Pathfinder.Official.Web.Services;
using Silvester.Pathfinder.Official.Web.Services.Currencies;
using Silvester.Pathfinder.Official.Web.Shared.Tables;
using Silvester.Pathfinder.Official.Web.Shared.Cards;
using Silvester.Pathfinder.Official.Web.Shared.Tables.Builder;
using Silvester.Pathfinder.Official.Web.Shared.Cards;
using Silvester.Pathfinder.Official.Web.Components.Cards.Details.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Silvester.Pathfinder.Official.Web.Shared.Cards.Builder;

namespace Silvester.Pathfinder.Official.Web.Components.Cards.Details
{
    public abstract partial class AbstractDetailsCard<TEntity> : ComponentBase
    {
        [Parameter]
        public TEntity? Entity { get; set; }

        [Inject]
        public PathfinderOfficialApi PathfinderOfficialApi { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public IActionTypeService ActionTypeService { get; set; } = default!;

        [Inject]
        public ICurrencyService CurrencyService { get; set; } = default!;

        public DetailsCardModel Model { get; private set; } = default!;

        protected RenderFragment Card { get; private set; } = default!;

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if(Entity != null)
            {
                Model = CreateModel(Entity);
            }

            Card = tree =>
            {
                tree.OpenElement(1, "div");
                tree.OpenComponent<ComponentDetailsCardModelAdapter<TEntity>>(2);
                tree.AddAttribute(2, "Model", Model);
                tree.AddAttribute(2, "Entity", Entity);
                tree.CloseComponent();
                tree.CloseElement();
            };
        }
        protected abstract DetailsCardModel CreateModel(TEntity entity);
    }
}
