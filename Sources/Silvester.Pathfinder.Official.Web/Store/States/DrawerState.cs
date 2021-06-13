using Fluxor;
using Silvester.Pathfinder.Official.Web.Store.Middlewares.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Web.Store.States
{
    public record DrawerState
    {
        public IImmutableDictionary<string, DrawerCategoryState> Categories { get; init; }

        public DrawerState()
        {
            Categories = new Dictionary<string, DrawerCategoryState>().ToImmutableDictionary();
        }
    }

    public record DrawerCategoryState
    {
        public bool IsExpanded{ get; init; }
    }

    public record SetCategoryExpandedAction : IPersistedAction
    {
        public bool IsExpanded { get; }

        public string Identifier { get; }

        public SetCategoryExpandedAction(string identifier, bool isExpanded) 
        {
            Identifier = identifier;
            IsExpanded = isExpanded;
        }
    }

    public class DrawerFeature : Feature<DrawerState>
    {
        public override string GetName() => "Drawer";
        protected override DrawerState GetInitialState() => new DrawerState();

        [ReducerMethod]
        public static DrawerState SetExpanded(DrawerState state, SetCategoryExpandedAction action)
        {
            Console.WriteLine("Reducing SetCategoryExpandedAction");

            if(state.Categories.TryGetValue(action.Identifier, out DrawerCategoryState? existing))
            {
                return state with
                {
                    Categories = state.Categories.Remove(action.Identifier).Add(action.Identifier, existing with
                    {
                        IsExpanded = action.IsExpanded
                    })
                };
            }
            else
            {
                return state with
                {
                    Categories = state.Categories.Add(action.Identifier, new DrawerCategoryState
                    {
                        IsExpanded = action.IsExpanded
                    })
                };
            }
        }
    }
}
