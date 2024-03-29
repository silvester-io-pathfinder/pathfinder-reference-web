﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Components.Tables.Instances.PlaneCategories.Providers
{
    public class PlaneCategoryPageProvider : GraphqlPageProvider<IPlaneCategoriesPage, PlaneCategorySortInput>
    {
        public PlaneCategoryPageProvider(IPathfinderReferenceApi api)
            : base(api)
        {

        }

        public override async Task<TableData<IPlaneCategoriesPage>> GetPage(PlaneCategorySortInput[] sortInputs, TableState state, string searchTerm)
        {
            IOperationResult<IGetPlaneCategoriesPageResult> result = await PathfinderReferenceApi.GetPlaneCategoriesPage
                     .ExecuteAsync(state.Page * state.PageSize, state.PageSize, searchTerm, sortInputs);

            if (result.Data?.PlaneCategories == null)
            {
                return EmptyPage();
            }

            TableData<IPlaneCategoriesPage> page = new TableData<IPlaneCategoriesPage>()
            {
                TotalItems = result.Data!.PlaneCategories!.TotalCount,
                Items = result.Data!.PlaneCategories!.Items!
            };

            return page;
        }
    }
}
