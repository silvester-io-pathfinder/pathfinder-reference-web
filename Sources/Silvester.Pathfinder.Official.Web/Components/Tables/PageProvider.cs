using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Components.Tables
{
    public interface IPageProvider<TEntity, TSortInput>
    {
        Task<TableData<TEntity>> GetPage(TSortInput[] sortInputs, TableState state, string searchTerm);
    }
}
