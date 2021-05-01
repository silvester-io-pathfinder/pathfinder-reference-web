using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Services
{
    public interface IBreakpointService
    {
        Breakpoint GetBreakpoint(int width);
    }

    public class BreakpointService : IBreakpointService
    {
        public Breakpoint GetBreakpoint(int width)
        {
            return width switch
            {
                < 600 => Breakpoint.Xs,
                < 960 => Breakpoint.Sm,
                < 1280 => Breakpoint.Md,
                < 1920 => Breakpoint.Lg,
                _ => Breakpoint.Xl
            };
        }
    }
}
