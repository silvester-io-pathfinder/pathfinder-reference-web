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
        bool IsMatch(Breakpoint breakpoint, Breakpoint target);
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

        public bool IsMatch(Breakpoint breakpoint, Breakpoint target)
        {
            Console.WriteLine("Determining match between " + breakpoint + " and " + target);
            return target switch
            {
                Breakpoint.Always => true,
                Breakpoint.None => false,
                Breakpoint.Xs => breakpoint == Breakpoint.Xs,
                Breakpoint.Sm => breakpoint == Breakpoint.Xs,
                Breakpoint.Md => breakpoint == Breakpoint.Xs,
                Breakpoint.Lg => breakpoint == Breakpoint.Xs,
                Breakpoint.Xl => breakpoint == Breakpoint.Xs,
                Breakpoint.SmAndDown => breakpoint == Breakpoint.Xs || breakpoint == Breakpoint.Sm,
                Breakpoint.MdAndDown => breakpoint == Breakpoint.Xs || breakpoint == Breakpoint.Sm || breakpoint == Breakpoint.Md,
                Breakpoint.LgAndDown => breakpoint == Breakpoint.Xs || breakpoint == Breakpoint.Sm || breakpoint == Breakpoint.Md || breakpoint == Breakpoint.Lg,
                Breakpoint.SmAndUp => breakpoint == Breakpoint.Sm || breakpoint == Breakpoint.Md || breakpoint == Breakpoint.Lg || breakpoint == Breakpoint.Xl,
                Breakpoint.MdAndUp => breakpoint == Breakpoint.Md || breakpoint == Breakpoint.Lg || breakpoint == Breakpoint.Xl,
                Breakpoint.LgAndUp => breakpoint == Breakpoint.Lg || breakpoint == Breakpoint.Xl,
                _ => throw new InvalidOperationException($"Unknown target breakpoint '{target}'.")
            };
        }
    }
}
