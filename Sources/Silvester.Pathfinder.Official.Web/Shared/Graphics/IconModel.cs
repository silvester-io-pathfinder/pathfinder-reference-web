using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Shared.Graphics
{
    public class IconModel
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public string Svg { get; set; }

        public IconModel(double height, double width, string svg)
        {
            Height = height;
            Width = width;
            Svg = svg;
        }
    }
}
