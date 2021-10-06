using Pluralize.NET.Core;
using Silvester.Pathfinder.Reference.Web.Graphql.Generated;
using StrawberryShake;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Services
{
    public interface ISearchService
    {
        Task<IEnumerable<ISearchResult>> Search(string searchTerm, CancellationToken cancellationToken = default);
        string GetLink(string type, Guid id);
    }

    public class SearchService : ISearchService
    {
        private IPathfinderReferenceApi PathfinderReferenceApi { get; }

        public SearchService(IPathfinderReferenceApi pathfinderReferenceApi)
        {
            PathfinderReferenceApi = pathfinderReferenceApi;
        }

        public async Task<IEnumerable<ISearchResult>> Search(string searchTerm, CancellationToken cancellationToken = default)
        {
            IOperationResult<ISearchByTermResult> result = await PathfinderReferenceApi.SearchByTerm
                    .ExecuteAsync(searchTerm, cancellationToken);

            if (result.Data?.Search == null)
            {
                return Array.Empty<ISearchResult>();
            }

            return result.Data.Search;
        }

        public string GetLink(string type, Guid id)
        {
            return $"{new Pluralizer().Pluralize(type).Replace(' ', '-').ToLower()}/{id}";

            /*
            return type switch
            {
                "Domain" => $"domains/{id}",
                "Ability" => $"abilities/{id}",
                "Action" => $"actions/{id}",
                //"Action Type" => $"action/{id}",
                "Adventuring Gear" => $"adventuring-gears/{id}",
                "Alchemical Bomb" => $"alchemical-bombs/{id}",
                "Alchemical Elixir" => $"alchemical-elixirs/{id}",
                "Alchemical Poison" => $"alchemical-poisons/{id}",
                "Alchemical Tool" => $"alchemical-tools/{id}",
                "Alignment" => $"alignments/{id}",
                "Ammunition" => $"ammunitions/{id}",
                "Armor" => $"armors/{id}",
                "Artifact" => $"artifacts/{id}",
                "Armor Property Rune" => $"armor-property-runes/{id}",
                "Armor Category" => $"armor-categories/{id}",
                "Armor Group" => $"armor-groups/{id}",
                //"Attack Type" => $"attack-types/{id}",
                "Benefit Type" => $"benefit-types/{id}",
                "Bulk" => $"bulks/{id}",
                "Class" => $"classes/{id}",
                "Condition Category" => $"condition-categories/{id}",
                "Condition" => $"conditions/{id}",
                "Curses" => $"curses/{id}",
                //"Damage Type" => $"damage-types/{id}",
                "Deity" => $"deities/{id}",
                "Deity Category" => $"deity-categories/{id}",
                "" => $"/{id}",
                "" => $"/{id}",
                "" => $"/{id}",
                "" => $"/{id}",
                "" => $"/{id}",
                "" => $"/{id}",
                "" => $"/{id}",
                "" => $"/{id}",
                "" => $"/{id}",
            };*/
        }
    }
}
