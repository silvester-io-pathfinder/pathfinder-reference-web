using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Races.Providers
{
    public class RacePageWithLanguageProvider : GraphqlPageProvider<IRacesPage, RaceSortInput>
    {
        private Guid LanguageId { get; }

        public RacePageWithLanguageProvider(IPathfinderOfficialApi api, Guid languageId)
            : base(api)
        {
            LanguageId = languageId;
        }

        public override async Task<TableData<IRacesPage>> GetPage(RaceSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetRacesPageWithLanguageResult> result = await PathfinderOfficialApi.GetRacesPageWithLanguage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, LanguageId, searchTerm, sortInputs);

            if (result?.Data?.Races == null)
            {
                return EmptyPage();
            }

            TableData<IRacesPage> page = new TableData<IRacesPage>()
            {
                TotalItems = result.Data!.Races!.TotalCount,
                Items = result.Data!.Races!.Items!
            };

            return page;
        }
    }
}
