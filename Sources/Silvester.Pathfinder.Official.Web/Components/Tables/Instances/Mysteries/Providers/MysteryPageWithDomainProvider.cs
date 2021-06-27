using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables.Instances.Mysteries.Providers
{
    public class MysteryPageWithDomainProvider : GraphqlPageProvider<IMysteriesPage, MysterySortInput>
    {
        private Guid DomainId { get; }

        public MysteryPageWithDomainProvider(IPathfinderOfficialApi api, Guid domainId)
            : base(api)
        {
            DomainId = domainId;
        }

        public override async Task<TableData<IMysteriesPage>> GetPage(MysterySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetMysteriesPageWithDomainResult> result = await PathfinderOfficialApi.GetMysteriesPageWithDomain
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, DomainId, searchTerm, sortInputs);

            if (result.Data?.Mysteries == null)
            {
                return EmptyPage();
            }

            TableData<IMysteriesPage> page = new TableData<IMysteriesPage>()
            {
                TotalItems = result.Data!.Mysteries!.TotalCount,
                Items = result.Data!.Mysteries!.Items!
            };

            return page;
        }
    }
}
