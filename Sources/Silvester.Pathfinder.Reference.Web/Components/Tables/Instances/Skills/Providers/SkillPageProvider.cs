using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Skills.Providers
{
    public class SkillPageProvider : GraphqlPageProvider<ISkillsPage, SkillSortInput>
    {
        public SkillPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<ISkillsPage>> GetPage(SkillSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetSkillsPageResult> result = await PathfinderOfficialApi.GetSkillsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.Skills == null)
            {
                return EmptyPage();
            }

            TableData<ISkillsPage> page = new TableData<ISkillsPage>()
            {
                TotalItems = result.Data!.Skills!.TotalCount,
                Items = result.Data!.Skills!.Items!
            };

            return page;
        }
    }
}
