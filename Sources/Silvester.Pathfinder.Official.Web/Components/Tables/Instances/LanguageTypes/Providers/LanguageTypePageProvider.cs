using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.LanguageTypes.Providers
{
    public class LanguageTypePageProvider : GraphqlPageProvider<ILanguageTypesPage, LanguageTypeSortInput>
    {
        public LanguageTypePageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<ILanguageTypesPage>> GetPage(LanguageTypeSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetLanguageTypesPageResult> result = await PathfinderOfficialApi.GetLanguageTypesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.LanguageTypes == null)
            {
                return EmptyPage();
            }

            TableData<ILanguageTypesPage> page = new TableData<ILanguageTypesPage>()
            {
                TotalItems = result.Data!.LanguageTypes!.TotalCount,
                Items = result.Data!.LanguageTypes!.Items!
            };

            return page;
        }
    }
}
