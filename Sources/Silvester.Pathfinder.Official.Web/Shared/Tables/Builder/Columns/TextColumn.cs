using System;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables.Builder.Columns
{
    public class TextColumn<TEntity> : ITableColumn<TEntity>, ISortable<TEntity>
    {
        public string Name { get; }

        public Func<TEntity, string?> ValueFunc { get; }

        public string SortLabel {get;}

        public bool IsBold { get; }

        public bool IsLastTextColumn { get; set; }

        public TextColumn(string name, string sortLabel, bool isBold, Func<TEntity, string?> valueFunc)
        {
            Name = name;
            SortLabel = sortLabel;
            IsBold = isBold;
            ValueFunc = valueFunc;
            IsLastTextColumn = false;
        }
    }
}
