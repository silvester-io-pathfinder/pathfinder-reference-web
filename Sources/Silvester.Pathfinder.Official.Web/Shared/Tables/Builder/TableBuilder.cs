using Silvester.Pathfinder.Official.Web.Shared.Tables.Builder.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MudBlazor;
using Microsoft.AspNetCore.Components;
using MudBlazor.Services;
using Silvester.Pathfinder.Official.Web.Services;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables.Builder
{
    public class TableBuilder<TEntity>
    {
        private IList<ITableColumn<TEntity>> Columns { get; }

        public bool IsSearchEnabled { get; set; }

        public int RowsPerPage { get; set; }

        public string? Title { get; set; }

        public TableBuilder()
        {
            Columns = new List<ITableColumn<TEntity>>();
            IsSearchEnabled = true;
            RowsPerPage = 25;
        }

        public TableBuilder<TEntity> AddIconColumn(Func<TEntity, string> svgFunc, string name, string sortLabel)
        {
            return Add(new IconColumn<TEntity>(name, sortLabel, svgFunc));
        }

        public TableBuilder<TEntity> AddTextColumn(Func<TEntity, string?> valueFunc, string name, string sortLabel, bool isBold = false, Breakpoint? hideBelow = null)
        {
            return Add(new TextColumn<TEntity>(name, sortLabel, isBold, hideBelow, valueFunc));
        }

        public TableBuilder<TEntity> AddActionColumn(Action<TEntity> onClick, string name, string tooltip, string icon, Size size = Size.Small)
        {
            return Add(new ActionColumn<TEntity>(onClick, name, icon, tooltip, size));
        }

        public TableBuilder<TEntity> AddInspectColumn(NavigationManager navigationManager, Func<TEntity, string> redirect)
        {
            return Add(new InspectColumn<TEntity>(navigationManager, redirect));
        }

        public TableBuilder<TEntity> Add(ITableColumn<TEntity> column)
        {
            Columns.Add(column);
            return this;
        }

        public TableModel<TEntity> Build()
        {
            return new TableModel<TEntity>(Columns, IsSearchEnabled, RowsPerPage, Title);
        }
    }

    public record TableModel<TEntity>
    {
        public IList<ITableColumn<TEntity>> Columns { get; }

        public bool IsSearchEnabled { get; }

        public int RowsPerPage { get; }

        public string? Title { get; }

        public bool IsInspectable => Columns.Any(e => e.GetType() == typeof(InspectColumn<TEntity>));

        public Action<TEntity> OnRowClick { get; }

        public TableModel(IList<ITableColumn<TEntity>> columns, bool isSearchEnabled, int rowsPerPage, string? title, Action<TEntity>? onRowClick = null)
        {
            Columns = columns;
            IsSearchEnabled = isSearchEnabled;
            RowsPerPage = rowsPerPage;
            Title = title;

            if(onRowClick == null)
            {
                OnRowClick = (e) => Columns
                    .OfType<InspectColumn<TEntity>>()
                    .FirstOrDefault()?
                    .OnClick(e);
            }
            else
            {
                OnRowClick = onRowClick;
            }
        }

        public bool IsLastVisibleTextColumn(TextColumn<TEntity> textColumn, BrowserWindowSize size, IBreakpointService breakpointService)
        {
            return GetLastVisibleTextColumn(breakpointService.GetBreakpoint(size.Width)) == textColumn;
        }

        public TextColumn<TEntity>? GetLastVisibleTextColumn(Breakpoint currentBreakpoint)
        {
            for(int i = Columns.Count - 1; i >= 0; i --)
            {
                ITableColumn<TEntity> current = Columns.ElementAt(i);
                if (current is TextColumn<TEntity> textColumn && (textColumn.HideBelow == null || currentBreakpoint > textColumn.HideBelow.Value))
                {
                    return textColumn;
                }
            }

            return null;
        }
    }
}
