using Fluxor;
using Silvester.Pathfinder.Official.Web.State;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public class Reducer
    {
        [ReducerMethod]
        public static AppBarState ReduceTitle(AppBarState state, SetPageTitleAction action)
        {
            return new AppBarState(action.TitleComponents);
        }
    }
}
