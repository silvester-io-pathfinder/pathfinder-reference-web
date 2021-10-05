using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Rest.Models
{
    public record Document
    {
        public DateTime CreationDate { get; }
        public DateTime LastModificationDate { get; }
        public int Version { get; }
        public Section[] Sections { get; } = default!;
    }

    public record Section
    {
        public string Title { get; } = default!;
        public SubSection[] SubSections { get; } = default!;
    }

    public record SubSection
    {
        public string? Title { get; }
        public string[] Paragraphs { get; } = default!;
    }
}
