using Fluxor;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Silvester.Pathfinder.Reference.Web.Store.Middlewares.Interfaces;
using Silvester.Pathfinder.Reference.Web.Themes;
using Silvester.Pathfinder.Reference.Web.Themes.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Store.States
{
    public enum Theme
    {
        Light,
        Dark
    }

    public record ThemeState
    {
        public Theme Theme { get; init; } = default!;
    }

    public record SetThemeAction : IPersistedAction
    {
        public Theme Theme { get; }

        public string Identifier => "Theme";

        public SetThemeAction(Theme theme)
        {
            Theme = theme;
        }
    }

    public class ThemeFeature : Feature<ThemeState>
    {
        public override string GetName() => "Theme";
        protected override ThemeState GetInitialState() => new ThemeState() { Theme = Theme.Light};

        [ReducerMethod]
        public static ThemeState SetAccepted(ThemeState state, SetThemeAction action)
        {
            return state with
            {
                Theme = action.Theme
            };
        }
    }

    public interface IThemeProvider : IDisposable
    {
        delegate void StateChangeDelegate();
        event StateChangeDelegate? StateChanged;
        
        CustomTheme Theme { get; }
    }

    public class ThemeProvider : IThemeProvider
    {
        public IState<ThemeState> State { get; }

        public CustomTheme Theme { get; private set; } = default!;
        
        public event IThemeProvider.StateChangeDelegate? StateChanged;

        public ThemeProvider(IState<ThemeState> state)
        {
            State = state;
            State.StateChanged += OnStateChange;

            OnStateChange(this, State.Value);
        }

        private void OnStateChange(object? sender, ThemeState state)
        {
            Theme = state.Theme == States.Theme.Light
                ? new LightTheme()
                : new DarkTheme();

            if(StateChanged != null)
            {
                StateChanged.Invoke();
            }
        }

        public void Dispose()
        {
            if(State != null)
            {
                State.StateChanged -= OnStateChange;
            }

            StateChanged = null;
        }
    }
}
