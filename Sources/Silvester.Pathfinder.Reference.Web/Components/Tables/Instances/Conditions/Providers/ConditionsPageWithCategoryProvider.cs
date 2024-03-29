﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.Conditions.Providers
{
    public class ConditionsPageWithCategoryProvider : GraphqlPageProvider<IConditionsPage, ConditionSortInput>
    {
        private Guid ConditionCategoryId { get; }

        public ConditionsPageWithCategoryProvider(IPathfinderReferenceApi api, Guid deityCategoryId)
            : base(api)
        {
            ConditionCategoryId = deityCategoryId;
        }

        public override async Task<TableData<IConditionsPage>> GetPage(ConditionSortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetConditionsPageWithCategoryResult> result = await PathfinderReferenceApi.GetConditionsPageWithCategory
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, ConditionCategoryId, searchTerm, sortInputs);

            if (result.Data?.Conditions == null)
            {
                return EmptyPage();
            }

            TableData<IConditionsPage> page = new TableData<IConditionsPage>()
            {
                TotalItems = result.Data!.Conditions!.TotalCount,
                Items = result.Data!.Conditions!.Items!
            };

            return page;
        }
    }
}
