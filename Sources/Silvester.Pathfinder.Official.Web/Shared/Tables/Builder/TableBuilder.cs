using Silvester.Pathfinder.Official.Web.Shared.Tables.Builder.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MudBlazor;
using Microsoft.AspNetCore.Components;
using MudBlazor.Services;
using Silvester.Pathfinder.Official.Web.Services;
using Silvester.Pathfinder.Official.Web.Services.Currencies;
using Silvester.Pathfinder.Official.Web.Shared.Graphics.ActionTypeIcons;
using Silvester.Pathfinder.Official.Web.Shared.Graphics;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables.Builder
{
    public class TableBuilder<TEntity> 
    {
        private IActionTypeService ActionTypeService { get; }

        private ICurrencyService CurrencyService { get; }

        private IList<ITableColumn<TEntity>> Columns { get; }

        public bool IsSearchEnabled { get; set; }

        public int RowsPerPage { get; set; }

        public string? Title { get; set; }

        public TableBuilder(IActionTypeService actionTypeService, ICurrencyService currencyService)
        {
            Columns = new List<ITableColumn<TEntity>>();
            IsSearchEnabled = true;
            RowsPerPage = 25;
            ActionTypeService = actionTypeService;
            CurrencyService = currencyService;
        }

        public TableBuilder<TEntity> AddActionIconColumn(Func<TEntity, string> actionTypeNameSelector, string sortLabel)
        {
            return AddIconColumn("Action", sortLabel, (e) => new ActionTypeIconBuilder(ActionTypeService).Build(actionTypeNameSelector(e), 24), hasDenseRightPadding: true);
        }

        public TableBuilder<TEntity> AddIconColumn(string name, string sortLabel, Func<TEntity, IconModel> getModel, bool hasDenseRightPadding = false)
        {
            return Add(new IconColumn<TEntity>(name, sortLabel, getModel, hasDenseRightPadding));
        }

        public TableBuilder<TEntity> AddPriceColumn(Func<TEntity, int?> valueFunc, string name, string sortLabel, bool isBold = false, Breakpoint? hideBelow = null)
        {
            return Add(new TextColumn<TEntity>(name, sortLabel, isBold, hideBelow, (e) => CurrencyService.Denormalize(valueFunc.Invoke(e)).ToString(), true));
        }

        public TableBuilder<TEntity> AddTextColumn(Func<TEntity, string?> valueFunc, string name, string sortLabel, bool isBold = false, Breakpoint? hideBelow = null, bool hasDenseRightPadding = false)
        {
            return Add(new TextColumn<TEntity>(name, sortLabel, isBold, hideBelow, valueFunc, hasDenseRightPadding));
        }

        public TableBuilder<TEntity> AddActionColumn(Action<TEntity> onClick, string name, string tooltip, string icon, Size size = Size.Small)
        {
            return Add(new ActionColumn<TEntity>(onClick, name, icon, tooltip, size, true));
        }

        public TableBuilder<TEntity> AddInspectColumn(NavigationManager navigationManager, Func<TEntity, string> redirect, bool hasDenseRightPadding = false)
        {
            return Add(new InspectColumn<TEntity>(navigationManager, redirect, hasDenseRightPadding));
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

        public bool IsLastVisibleTextColumn(ITableColumn<TEntity> column, int windowWidth, IBreakpointService breakpointService)
        {
            if(!(column is TextColumn<TEntity> textColumn))
            {
                return false;
            }

            return GetLastVisibleTextColumn(breakpointService.GetBreakpoint(windowWidth), breakpointService) == textColumn;
        }

        public TextColumn<TEntity>? GetLastVisibleTextColumn(Breakpoint currentBreakpoint, IBreakpointService breakpointService)
        {
            for(int i = Columns.Count - 1; i >= 0; i --)
            {
                ITableColumn<TEntity> current = Columns.ElementAt(i);
                if (current is TextColumn<TEntity> textColumn && (textColumn.HideBelow == null || breakpointService.IsMatch(currentBreakpoint, textColumn.HideBelow.Value) == false))
                {
                    return textColumn;
                }
            }

            return null;
        }
    }
}
