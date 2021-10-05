using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Armors.Providers
{
    public class ArmorPageWithCategoryProvider : GraphqlPageProvider<IArmorsPage, ArmorSortInput>
    {
        private Guid WeaponCategoryId { get; }

        public ArmorPageWithCategoryProvider(IPathfinderReferenceApi api, Guid weaponCategoryId)
            : base(api)
        {
            WeaponCategoryId = weaponCategoryId;
        }

        public override async Task<TableData<IArmorsPage>> GetPage(ArmorSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetArmorPageWithCategoryResult> result = await PathfinderReferenceApi.GetArmorPageWithCategory
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, WeaponCategoryId, searchTerm, sortInputs);

            if (result.Data?.Armors == null)
            {
                return EmptyPage();
            }

            TableData<IArmorsPage> page = new TableData<IArmorsPage>()
            {
                TotalItems = result.Data!.Armors!.TotalCount,
                Items = result.Data!.Armors!.Items!
            };

            return page;
        }
    }
}
