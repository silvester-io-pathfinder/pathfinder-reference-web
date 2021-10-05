using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Spells.Providers
{
    public class SpellPageWithSchoolProvider : GraphqlPageProvider<ISpellsPage, SpellSortInput>
    {
        private Guid MagicSchoolId { get; }

        public SpellPageWithSchoolProvider(IPathfinderOfficialApi api, Guid magicSchoolId)
            : base(api)
        {
            MagicSchoolId = magicSchoolId;
        }

        public override async Task<TableData<ISpellsPage>> GetPage(SpellSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetSpellsPageWithSchoolResult> result = await PathfinderOfficialApi.GetSpellsPageWithSchool
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, MagicSchoolId, searchTerm, sortInputs);

            if (result?.Data?.Spells == null)
            {
                return EmptyPage();
            }

            TableData<ISpellsPage> page = new TableData<ISpellsPage>()
            {
                TotalItems = result.Data!.Spells!.TotalCount,
                Items = result.Data!.Spells!.Items!
            };

            return page;
        }
    }
}
