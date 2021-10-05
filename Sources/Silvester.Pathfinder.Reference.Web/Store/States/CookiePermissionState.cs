using Fluxor;
using Silvester.Pathfinder.Official.Web.Store.Middlewares.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public record CookiePermissionState
    {
        public bool CanUseEssentialCookies { get; init; }
        public bool CanUseNonEssentialCookies { get; init; }
        public bool HasDeclaredCookiePreferences { get; init; }
    }

    public record SetCookiePermissionAcceptedAction : IPersistedAction
    {
        public bool CanUseEssentialCookies { get; }
        public bool CanUseNonEssentialCookies { get; }

        public string Identifier => "CookiePermissionsAccepted";

        public SetCookiePermissionAcceptedAction(bool canUseEssentialCookies, bool canUseNonEssentialCookies)
        {
            CanUseEssentialCookies = canUseEssentialCookies;
            CanUseNonEssentialCookies = canUseNonEssentialCookies;
        }
    }

    public class CookiePermissionFeature : Feature<CookiePermissionState>
    {
        public override string GetName() => "CookiePermission";
        protected override CookiePermissionState GetInitialState() => new CookiePermissionState();

        [ReducerMethod]
        public static CookiePermissionState SetAccepted(CookiePermissionState state, SetCookiePermissionAcceptedAction action)
        {
            return state with
            {
                HasDeclaredCookiePreferences = true,
                CanUseEssentialCookies = action.CanUseEssentialCookies,
                CanUseNonEssentialCookies = action.CanUseNonEssentialCookies
            };
        }
    }
}
