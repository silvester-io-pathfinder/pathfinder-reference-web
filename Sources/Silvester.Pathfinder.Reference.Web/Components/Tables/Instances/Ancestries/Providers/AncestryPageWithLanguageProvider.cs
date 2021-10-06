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
    public class AncestryPageWithLanguageProvider : GraphqlPageProvider<IAncestriesPage, AncestrySortInput>
    {
        private Guid LanguageId { get; }

        public AncestryPageWithLanguageProvider(IPathfinderReferenceApi api, Guid languageId)
            : base(api)
        {
            LanguageId = languageId;
        }

        public override async Task<TableData<IAncestriesPage>> GetPage(AncestrySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetAncestriesPageWithLanguageResult> result = await PathfinderReferenceApi.GetAncestriesPageWithLanguage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, LanguageId, searchTerm, sortInputs);

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
