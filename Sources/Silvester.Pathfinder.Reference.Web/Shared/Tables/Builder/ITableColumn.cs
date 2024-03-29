﻿using MudBlazor;

namespace Silvester.Pathfinder.Reference.Web.Shared.Tables.Builder
{
    public interface ITableColumn<TEntity>
    {
        public string Name { get; }

        public Breakpoint? HideBelow { get; set; }

        public bool HasDenseRightPadding { get; set; }
    }
}
