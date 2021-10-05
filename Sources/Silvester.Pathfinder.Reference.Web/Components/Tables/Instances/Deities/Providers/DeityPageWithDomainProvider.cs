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
    public class DeityPageWithDomainProvider : GraphqlPageProvider<IDeitiesPage, DeitySortInput>
    {
        private Guid DomainId { get; }

        public DeityPageWithDomainProvider(IPathfinderReferenceApi api, Guid domainId)
            : base(api)
        {
            DomainId = domainId;
        }

        public override async Task<TableData<IDeitiesPage>> GetPage(DeitySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetDeitiesPageWithDomainResult> result = await PathfinderReferenceApi.GetDeitiesPageWithDomain
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, DomainId, searchTerm, sortInputs);

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
