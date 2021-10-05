using Silvester.Pathfinder.Official.Web.Services;

namespace Silvester.Pathfinder.Official.Web.Shared.Graphics.ActionTypeIcons
{
    public class ActionTypeIconBuilder
    {
        private IActionTypeService ActionTypeService { get; }

        public ActionTypeIconBuilder(IActionTypeService actionTypeService)
        {
            ActionTypeService = actionTypeService;
        }

        public IconModel? Build(string? name, int height)
        {
            return string.IsNullOrEmpty(name)
                ? null
                : new IconModel(height, ActionTypeService.GetActionTypeIconWidth(name, height), ActionTypeService.GetActionTypeIcon(name));
        }
    }
}
