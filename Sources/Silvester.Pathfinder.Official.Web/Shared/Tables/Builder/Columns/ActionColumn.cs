using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MudBlazor;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables.Builder.Columns
{
    public class ActionColumn<TEntity> : ITableColumn<TEntity>
    {
        public Action<TEntity> OnClick { get; }

        public string Name { get; }

        public string Icon { get; }

        public string Tooltip { get; }

        public Size Size { get; }
        
        public Breakpoint? HideBelow { get; set; }

        public ActionColumn(Action<TEntity> onClick, string name, string icon, string tooltip, Size size)
        {
            OnClick = onClick;
            Name = name;
            Icon = icon;
            Tooltip = tooltip;
            Size = size;
        }
    }
}
