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
        public bool HasAccepted { get; init; }
    }

    public record SetCookiePermissionAcceptedAction : IPersistedAction
    {
        public bool HasAccepted { get; }

        public string Identifier => "CookiePermissionsAccepted";

        public SetCookiePermissionAcceptedAction(bool hasAccepted)
        {
            HasAccepted = hasAccepted;
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
                HasAccepted = action.HasAccepted
            };
        }
    }
}
