using MudBlazor;
using System;

namespace Silvester.Pathfinder.Reference.Web.Shared.Tables.Builder.Columns
{
    public class TextColumn<TEntity> : ITableColumn<TEntity>, ISortable<TEntity>
    {
        public string Name { get; }

        public Func<TEntity, string?> ValueFunc { get; }

        public string SortLabel { get; }

        public bool IsBold { get; }
        
        public bool HasDenseRightPadding { get; set; }

        public Func<bool> IsLastVisibleTextColumn { get; set; } = default!;

        public Breakpoint? HideBelow { get; set; }

        public TextColumn(string name, string sortLabel, bool isBold, Breakpoint? hideBelow, Func<TEntity, string?> valueFunc, bool hasDenseRightPadding)
        {
            Name = name;
            SortLabel = sortLabel;
            IsBold = isBold;
            HideBelow = hideBelow;
            ValueFunc = valueFunc;
            HasDenseRightPadding = hasDenseRightPadding;
        }
    }
}
