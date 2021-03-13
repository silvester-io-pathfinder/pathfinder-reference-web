using Silvester.Pathfinder.Official.Web.Shared.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Mocked
{
    public class Spell
    {
        public string Name { get; set; } = default!;

        public Guid Id { get; set; }

        public bool Relearnable { get; set; }

        public int Level { get; set; }

        public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc et mi ac ligula accumsan dignissim. Phasellus id ante eget massa auctor malesuada id eget lorem. Nulla accumsan varius lacus, vitae pharetra risus laoreet vitae. Mauris ultrices ante eget consectetur fringilla. Etiam vitae dignissim diam. Nam maximus ultricies neque quis lacinia. Curabitur iaculis gravida rutrum. Phasellus eu tempor augue, vel porttitor dolor. In hac habitasse platea dictumst. Nunc pretium at risus et vestibulum. Nam in lacus sit amet risus accumsan feugiat sed eu enim. Nullam congue orci et neque tristique rhoncus. Nullam ac nibh id leo ultrices iaculis. Donec lacus tortor, venenatis a molestie vel, facilisis sodales metus. Nulla consectetur laoreet justo id molestie.Integer et varius mauris.Donec imperdiet accumsan augue, id venenatis sapien mollis a.Quisque in nunc ultricies, sagittis enim vitae, ultricies tellus. Mauris malesuada vitae nibh sed cursus. Nulla imperdiet scelerisque turpis quis blandit. Vivamus vestibulum ultrices ex ac fringilla.";
    }

    public class SpellService : IEntityService<Spell>
    {
        public IEnumerable<Spell> Filter(IEnumerable<Spell> input, string searchTerm)
        {
            return input
                .Where(entity =>
                {
                    return string.IsNullOrWhiteSpace(searchTerm)
                        || entity.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                        || entity.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
                });
        }

        public Task<IEnumerable<Spell>> GetEntitiesAsync()
        {
            if (Cache == null)
            {
                Cache = GenerateSpells();
            }

            return Task.FromResult(Cache);
        }

        private static IEnumerable<Spell>? Cache = null;

        public IEnumerable<Spell> GenerateSpells()
        {
            for (int i = 0; i < 50; i++)
            {
                yield return new Spell { Id = Guid.NewGuid(), Name = "Spell " + i, Level = i % 8 };
            }
        }
    }

}
