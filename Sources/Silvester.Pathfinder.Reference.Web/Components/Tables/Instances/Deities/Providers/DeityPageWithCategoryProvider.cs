using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Deities.Providers
{
    public class DeityPageWithCategoryProvider : GraphqlPageProvider<IDeitiesPage, DeitySortInput>
    {
        private Guid DeityCategoryId { get; }

        public DeityPageWithCategoryProvider(IPathfinderReferenceApi api, Guid deityCategoryId)
            : base(api)
        {
            DeityCategoryId = deityCategoryId;
        }

        public override async Task<TableData<IDeitiesPage>> GetPage(DeitySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetDeitiesPageWithCategoryResult> result = await PathfinderReferenceApi.GetDeitiesPageWithCategory
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, DeityCategoryId, searchTerm, sortInputs);

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
