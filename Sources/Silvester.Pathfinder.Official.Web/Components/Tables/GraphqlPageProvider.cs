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

    public abstract class GraphqlPageProvider<TEntity, TSortInput> : IPageProvider<TEntity, TSortInput>
    {
        protected IPathfinderOfficialApi PathfinderOfficialApi { get; }

        public GraphqlPageProvider(IPathfinderOfficialApi pathfinderOfficialApi)
        {
            PathfinderOfficialApi = pathfinderOfficialApi;
        }

        protected TableData<TEntity> EmptyPage()
        {
            return new TableData<TEntity>()
            {
                TotalItems = 0,
                Items = Array.Empty<TEntity>()
            };
        }

        public abstract Task<TableData<TEntity>> GetPage(TSortInput[] sortInputs, TableState state, string searchTerm);
    }
}
