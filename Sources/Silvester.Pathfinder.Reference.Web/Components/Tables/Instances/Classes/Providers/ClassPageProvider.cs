using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Classes.Providers
{
    public class ClassPageProvider : GraphqlPageProvider<IClassesPage, ClassSortInput>
    {
        public ClassPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IClassesPage>> GetPage(ClassSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetClassesPageResult> result = await PathfinderOfficialApi.GetClassesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Classes == null)
            {
                return EmptyPage();
            }

            TableData<IClassesPage> page = new TableData<IClassesPage>()
            {
                TotalItems = result.Data!.Classes!.TotalCount,
                Items = result.Data!.Classes!.Items!
            };

            return page;
        }
    }
}
