using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Shared.Appbar.Models
{
    public interface IAppbarItem
    {
        //Marker pattern.
    }

    public class DividerItem : IAppbarItem
    {

    }

    public class ActionItem : IAppbarItem
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public Func<Task> OnClick { get; set; }

        public ActionItem(string text, string icon, Func<Task> onClick)
        {
            Text = text;
            Icon = icon;
            OnClick = onClick;
        }
    }

    public record LinkItem : IAppbarItem
    {
        public string Text { get; set; } 
        public string Icon { get; set; } 
        public string Link { get; set; }
        public string Target { get; set; }

        public LinkItem(string text, string icon,  string link, string target = "_blank")
        {
            Text = text;
            Icon = icon;
            Link = link;
            Target = target;
        }
    }
}
