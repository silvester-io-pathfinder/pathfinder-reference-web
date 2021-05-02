using MudBlazor;
using System;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables.Builder.Columns
{
    public class IconColumn<TEntity> : ITableColumn<TEntity>, ISortable<TEntity>
    {
        public Func<TEntity, string> SvgFunc { get; }
        public Func<TEntity, double> WidthFunc { get; }

        public string Name { get; }

        public string SortLabel { get; }

        public Breakpoint? HideBelow { get; set; }

        public bool HasDenseRightPadding { get; set; }

        public int Height { get; set; }

        public IconColumn(string name, string sortLabel, int height, Func<TEntity, string> svgFunc, Func<TEntity, double> widthFunc, bool hasDenseRightPadding)
        {
            Name = name;
            SortLabel = sortLabel;
            Height = height;
            SvgFunc = svgFunc;
            WidthFunc = widthFunc;
            HasDenseRightPadding = hasDenseRightPadding;
        }
    }
}
