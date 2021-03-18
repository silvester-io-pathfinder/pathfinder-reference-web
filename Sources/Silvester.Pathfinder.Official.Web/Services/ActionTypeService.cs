namespace Silvester.Pathfinder.Official.Web.Services
{
    public interface IActionTypeService
    {
        string GetActionTypeIcon(string actionName);
    }

    public class ActionTypeService : IActionTypeService
    {
        public string GetActionTypeIcon(string actionName)
        {
            return actionName switch
            {
                "One Action" => Icons.Generated.OneAction,
                "Two Actions" => Icons.Generated.TwoActions,
                "Three Actions" => Icons.Generated.ThreeActions,
                "Free Action" => Icons.Generated.FreeAction,
                "Reaction" => Icons.Generated.Reaction,
                _ => ""
            };
        }
    }
}
