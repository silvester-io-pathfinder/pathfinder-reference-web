using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Artifacts.Providers
{
    public class ArtifactPageProvider : GraphqlPageProvider<IArtifactsPage, ArtifactSortInput>
    {
        public ArtifactPageProvider(IPathfinderOfficialApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IArtifactsPage>> GetPage(ArtifactSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetArtifactsPageResult> result = await PathfinderOfficialApi.GetArtifactsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result?.Data?.Artifacts == null)
            {
                return EmptyPage();
            }

            TableData<IArtifactsPage> page = new TableData<IArtifactsPage>()
            {
                TotalItems = result.Data!.Artifacts!.TotalCount,
                Items = result.Data!.Artifacts!.Items!
            };

            return page;
        }
    }
}
