using MudBlazor;
using Silvester.Pathfinder.Official.Web.Shared.Graphics;
using System;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables.Builder.Columns
{
    public class IconColumn<TEntity> : ITableColumn<TEntity>, ISortable<TEntity>
    {
        public Func<TEntity, IconModel> GetModel { get; }

        public string Name { get; }

        public string SortLabel { get; }

        public Breakpoint? HideBelow { get; set; }

        public bool HasDenseRightPadding { get; set; }

        public IconColumn(string name, string sortLabel, Func<TEntity, IconModel> getModel, bool hasDenseRightPadding)
        {
            Name = name;
            SortLabel = sortLabel;
            GetModel = getModel;
            HasDenseRightPadding = hasDenseRightPadding;
        }
    }
}
