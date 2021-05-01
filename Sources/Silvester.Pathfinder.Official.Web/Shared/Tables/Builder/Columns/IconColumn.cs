using MudBlazor;
using System;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables.Builder.Columns
{
    public class IconColumn<TEntity> : ITableColumn<TEntity>, ISortable<TEntity>
    {
        public Func<TEntity, string> SvgFunc { get;  }

        public string Name { get; }

        public string SortLabel { get; }

        public Breakpoint? HideBelow { get; set; }

        public IconColumn(string name, string sortLabel, Func<TEntity, string> svgFunc)
        {
            Name = name;
            SortLabel = sortLabel;
            SvgFunc = svgFunc;
        }
    }
}
