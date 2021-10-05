using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Deities.Providers
{
    public class DeityPageWithDivineFontProvider : GraphqlPageProvider<IDeitiesPage, DeitySortInput>
    {
        private string DivineFontName { get; }

        public DeityPageWithDivineFontProvider(IPathfinderOfficialApi api, string divineFontName)
            : base(api)
        {
            DivineFontName = divineFontName;
        }

        public override async Task<TableData<IDeitiesPage>> GetPage(DeitySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetDeitiesPageWithDivineFontResult> result = await PathfinderOfficialApi.GetDeitiesPageWithDivineFont
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, DivineFontName, searchTerm, sortInputs);

            if (result.Data?.Deities == null)
            {
                return EmptyPage();
            }

            TableData<IDeitiesPage> page = new TableData<IDeitiesPage>()
            {
                TotalItems = result.Data!.Deities!.TotalCount,
                Items = result.Data!.Deities!.Items!
            };

            return page;
        }
    }
}
