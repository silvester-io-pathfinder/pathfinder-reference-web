using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Official.Web.Graphql;
using Silvester.Pathfinder.Official.Web.Graphql.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables
{
    public interface IEntityService<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetEntitiesAsync();
        public IEnumerable<TEntity> Filter(IEnumerable<TEntity> input, string searchTerm);
    }

    public partial class GraphqlTable<TEntity>
    {
        [Parameter] 
        public RenderFragment<TEntity> Rows{ get; set; } = default!;

        [Parameter]
        public RenderFragment Columns { get; set; } = default!;

        [Parameter]
        public string Title { get; set; } = default!;

        [Parameter]
        public int RowsPerPage { get; set; } = 10;

        public string? SearchTerm { get; set; }
        
        public MudTable<TEntity>? Table { get; set; }

        private bool IsLoading { get; set; }

        [Parameter]
        public Func<TableState, string?, Task<TableData<TEntity>>> GetPage { get; set; } = default!;

        public async Task<TableData<TEntity>> GetServerData(TableState state)
        {
            IsLoading = true;
            StateHasChanged();

            TableData<TEntity> result = await GetPage(state, SearchTerm);
            
            IsLoading = false;
            StateHasChanged();

            return result;
        }

        public void OnSearch(string searchTerm)
        {
            SearchTerm = searchTerm;
            Table!.ReloadServerData();
        }
    }
}
