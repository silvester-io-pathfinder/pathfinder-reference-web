namespace Silvester.Pathfinder.Reference.Web.Services
{
    public interface IActionTypeService
    {
        string GetActionTypeIcon(string actionName);
        double GetActionTypeIconWidth(string actionName, int height);
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
                "Free" => Icons.Generated.FreeAction,
                "Reaction" => Icons.Generated.Reaction,
                _ => ""
            };
        }

        public double GetActionTypeIconWidth(string actionName, int height)
        {
            return actionName switch
            {
                "One Action" => height,
                "Two Actions" => (height / 32d) * 50d,
                "Three Actions" => (height / 32d) * 65.5d,
                "Free" => height,
                "Reaction" => height,
                _ => height
            };
        }

    }
}
