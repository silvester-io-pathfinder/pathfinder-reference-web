using MudBlazor;

namespace Silvester.Pathfinder.Official.Web.Shared.Tables.Builder
{
    public interface ITableColumn<TEntity>
    {
        public string Name { get; }

        public Breakpoint? HideBelow { get; set; }
    }
}
