using Silvester.Pathfinder.Official.Web.Shared.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Mocked
{

    public class Feat
    {
        public override bool Equals(object? obj)
        {
            return false;
        }

        public Feat()
        {

        }

        public Feat(Guid id, string name, int level, bool canBeLearnedMoreThanOnce)
        {
            Id = id;
            Name = name;
            Level = level;
            CanBeLearnedMoreThanOnce = canBeLearnedMoreThanOnce;
        }

        public string Name { get; set; } = default!;

        public Guid Id { get; set; }

        public bool CanBeLearnedMoreThanOnce { get; set; }

        public int Level { get; set; }

        public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc et mi ac ligula accumsan dignissim. Phasellus id ante eget massa auctor malesuada id eget lorem. Nulla accumsan varius lacus, vitae pharetra risus laoreet vitae. Mauris ultrices ante eget consectetur fringilla. Etiam vitae dignissim diam. Nam maximus ultricies neque quis lacinia. Curabitur iaculis gravida rutrum. Phasellus eu tempor augue, vel porttitor dolor. In hac habitasse platea dictumst. Nunc pretium at risus et vestibulum. Nam in lacus sit amet risus accumsan feugiat sed eu enim. Nullam congue orci et neque tristique rhoncus. Nullam ac nibh id leo ultrices iaculis. Donec lacus tortor, venenatis a molestie vel, facilisis sodales metus. Nulla consectetur laoreet justo id molestie.Integer et varius mauris.Donec imperdiet accumsan augue, id venenatis sapien mollis a.Quisque in nunc ultricies, sagittis enim vitae, ultricies tellus. Mauris malesuada vitae nibh sed cursus. Nulla imperdiet scelerisque turpis quis blandit. Vivamus vestibulum ultrices ex ac fringilla.";

        public ActionType ActionType { get; set; } = ActionType.Random;
    }

    public class FeatService : IEntityService<Feat>
    {
        public IEnumerable<Feat> Filter(IEnumerable<Feat> input, string searchTerm)
        {
            return input
                .Where(entity =>
                {
                    return string.IsNullOrWhiteSpace(searchTerm)
                        || entity.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                        || entity.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
                });
        }

        public Task<IEnumerable<Feat>> GetEntitiesAsync()
        {
            if (Cache == null)
            {
                Cache = GenerateFeats().ToArray();
            }

            return Task.FromResult(Cache.AsEnumerable());
        }

        private static Feat[]? Cache = null;

        public IEnumerable<Feat> GenerateFeats()
        {
            for (int i = 0; i < 54; i++)
            {
                yield return new Feat 
                {
                    Id = Guid.NewGuid(), 
                    Name = "Feat " + i, 
                    Level = i % 8
                };
            }
        }


    }
}
