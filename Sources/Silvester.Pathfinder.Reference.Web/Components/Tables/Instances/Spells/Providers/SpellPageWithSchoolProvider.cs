using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Spells.Providers
{
    public class SpellPageWithSchoolProvider : GraphqlPageProvider<ISpellsPage, SpellSortInput>
    {
        private Guid MagicSchoolId { get; }

        public SpellPageWithSchoolProvider(IPathfinderReferenceApi api, Guid magicSchoolId)
            : base(api)
        {
            MagicSchoolId = magicSchoolId;
        }

        public override async Task<TableData<ISpellsPage>> GetPage(SpellSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetSpellsPageWithSchoolResult> result = await PathfinderReferenceApi.GetSpellsPageWithSchool
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
