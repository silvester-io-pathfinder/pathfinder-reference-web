using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Languages.Providers
{
    public class LanguagePageWithTypeProvider : GraphqlPageProvider<ILanguagesPage, LanguageSortInput>
    {
        private Guid LanguageTypeId { get; }

        public LanguagePageWithTypeProvider(IPathfinderReferenceApi api, Guid languageTypeId)
            : base(api)
        {
            LanguageTypeId = languageTypeId;
        }

        public override async Task<TableData<ILanguagesPage>> GetPage(LanguageSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetLanguagesPageWithTypeResult> result = await PathfinderReferenceApi.GetLanguagesPageWithType
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, LanguageTypeId, searchTerm, sortInputs);

            if (result.Data?.Languages == null)
            {
                return EmptyPage();
            }

            TableData<ILanguagesPage> page = new TableData<ILanguagesPage>()
            {
                TotalItems = result.Data!.Languages!.TotalCount,
                Items = result.Data!.Languages!.Items!
            };

            return page;
        }
    }
}
