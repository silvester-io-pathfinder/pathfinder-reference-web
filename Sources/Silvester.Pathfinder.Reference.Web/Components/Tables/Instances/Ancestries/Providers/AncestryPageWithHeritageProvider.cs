using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Ancestries.Providers
{
    public class AncestryPageWithHeritageProvider : GraphqlPageProvider<IAncestriesPage, AncestrySortInput>
    {
        private Guid HeritageId { get; }

        public AncestryPageWithHeritageProvider(IPathfinderReferenceApi api, Guid heritageId)
            : base(api)
        {
            HeritageId = heritageId;
        }

        public override async Task<TableData<IAncestriesPage>> GetPage(AncestrySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAncestriesPageWithHeritageResult> result = await PathfinderReferenceApi.GetAncestriesPageWithHeritage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, HeritageId, searchTerm, sortInputs);

            if (result?.Data?.Ancestries == null)
            {
                return EmptyPage();
            }

            TableData<IAncestriesPage> page = new TableData<IAncestriesPage>()
            {
                TotalItems = result.Data!.Ancestries!.TotalCount,
                Items = result.Data!.Ancestries!.Items!
            };

            return page;
        }
    }
}
