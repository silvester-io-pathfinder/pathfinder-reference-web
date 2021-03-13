using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Mocked
{
    public class ActionType
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = default!;

        public static readonly ActionType NO_ACTION = new ActionType { Id = Guid.NewGuid(), Name = "No Action" };
        public static readonly ActionType FREE = new ActionType { Id = Guid.NewGuid(), Name = "Free" };
        public static readonly ActionType REACTION = new ActionType { Id = Guid.NewGuid(), Name = "Reaction" };
        public static readonly ActionType ONE_ACTION = new ActionType { Id = Guid.NewGuid(), Name = "One Action" };
        public static readonly ActionType TWO_ACTIONS = new ActionType { Id = Guid.NewGuid(), Name = "Two Actions" };
        public static readonly ActionType THREE_ACTIONS = new ActionType { Id = Guid.NewGuid(), Name = "Three Actions" };
        public static readonly ActionType ONE_OR_TWO_ACTIONS = new ActionType { Id = Guid.NewGuid(), Name = "One or Two Actions" };
        public static readonly ActionType TWO_OR_THREE_ACTIONS = new ActionType { Id = Guid.NewGuid(), Name = "Two or Three Actions" };

        public static readonly ActionType[] Values = new[] { NO_ACTION, FREE, REACTION, ONE_ACTION, TWO_ACTIONS, THREE_ACTIONS, ONE_OR_TWO_ACTIONS, TWO_OR_THREE_ACTIONS };

        public static ActionType Random => Values.ElementAt(new Random().Next(0, Values.Length - 1));
    }
}
