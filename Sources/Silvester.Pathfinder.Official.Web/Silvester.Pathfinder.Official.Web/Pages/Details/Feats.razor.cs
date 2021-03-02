using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Pages.Details
{
    public class Feat
    {
        public string Name { get; set; }

        public Guid Id { get; set; }

        public bool Relearnable { get; set; }

        public int Level { get; set; }

        public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc et mi ac ligula accumsan dignissim. Phasellus id ante eget massa auctor malesuada id eget lorem. Nulla accumsan varius lacus, vitae pharetra risus laoreet vitae. Mauris ultrices ante eget consectetur fringilla. Etiam vitae dignissim diam. Nam maximus ultricies neque quis lacinia. Curabitur iaculis gravida rutrum. Phasellus eu tempor augue, vel porttitor dolor. In hac habitasse platea dictumst. Nunc pretium at risus et vestibulum. Nam in lacus sit amet risus accumsan feugiat sed eu enim. Nullam congue orci et neque tristique rhoncus. Nullam ac nibh id leo ultrices iaculis. Donec lacus tortor, venenatis a molestie vel, facilisis sodales metus. Nulla consectetur laoreet justo id molestie.Integer et varius mauris.Donec imperdiet accumsan augue, id venenatis sapien mollis a.Quisque in nunc ultricies, sagittis enim vitae, ultricies tellus. Mauris malesuada vitae nibh sed cursus. Nulla imperdiet scelerisque turpis quis blandit. Vivamus vestibulum ultrices ex ac fringilla.";
    }

    public partial class Feats : BaseDetailsPage
    {
        protected override string Title => "Feats";

        public MudTable<Feat>? Table { get; set; }

        public string? SearchString { get; set; }

        public IEnumerable<Feat> AllFeats()
        {
            for (int i = 0; i < 50; i++)
            {
                yield return new Feat { Id = Guid.NewGuid(), Name = "Feat " + i, Level = i % 8};
            }
        }

        public async Task<TableData<Feat>> GetFeatPage(TableState state)
        {
            IEnumerable<Feat> data = AllFeats()
                .Where(element =>
                {
                    return string.IsNullOrWhiteSpace(SearchString)
                    || element.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase)
                    || element.Description.Contains(SearchString, StringComparison.OrdinalIgnoreCase);
                });


            if (string.IsNullOrWhiteSpace(state.SortLabel) == false)
            {
                data = data.OrderByDirection(state.SortDirection, element =>
                {
                    PropertyInfo property = element.GetType().GetProperty(state.SortLabel)!;
                    return property.GetValue(element);
                });
            }
             
            data = data
                .Skip(state.Page * state.PageSize)
                .Take(state.PageSize)
                .ToArray();

            return new TableData<Feat>() { TotalItems = AllFeats().Count(), Items = data };
        }

        public void OnSearch(string text)
        {
            SearchString = text;
            Table!.ReloadServerData();
        }
    }
}
