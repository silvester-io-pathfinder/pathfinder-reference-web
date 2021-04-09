using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Feats.Providers
{
    public class FeatPageWithTraitProvider : GraphqlPageProvider<IFeatsPage, FeatSortInput>
    {
        private Guid TraitId { get; }

        public FeatPageWithTraitProvider(IPathfinderOfficialApi api, Guid traitId)
            : base(api)
        {
            TraitId = traitId;
        }

        public override async Task<TableData<IFeatsPage>> GetPage(FeatSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetFeatsPageWithTraitResult> result = await PathfinderOfficialApi.GetFeatsPageWithTrait
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, TraitId, searchTerm, sortInputs);

            if (result.Data?.Feats == null)
            {
                return EmptyPage();
            }

            TableData<IFeatsPage> page = new TableData<IFeatsPage>()
            {
                TotalItems = result.Data!.Feats!.TotalCount,
                Items = result.Data!.Feats!.Items!
            };

            return page;
        }
    }
}
