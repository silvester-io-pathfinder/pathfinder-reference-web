using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Domains.Providers
{
    public class DomainPageProvider : GraphqlPageProvider<IDomainsPage, DomainSortInput>
    {
        public DomainPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IDomainsPage>> GetPage(DomainSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetDomainsPageResult> result = await PathfinderReferenceApi.GetDomainsPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.Domains == null)
            {
                return EmptyPage();
            }

            TableData<IDomainsPage> page = new TableData<IDomainsPage>()
            {
                TotalItems = result.Data!.Domains!.TotalCount,
                Items = result.Data!.Domains!.Items!
            };

            return page;
        }
    }
}
