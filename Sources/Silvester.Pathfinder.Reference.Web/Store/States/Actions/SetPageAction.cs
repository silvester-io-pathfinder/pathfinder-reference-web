﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Store.States.Actions
{
    public record SetPageAction(string Collection, string? ResourceName, Guid? ResourceId);
}
