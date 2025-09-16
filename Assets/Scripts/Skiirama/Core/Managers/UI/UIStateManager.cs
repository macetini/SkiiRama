using System;
using System.Collections.Generic;
using Assets.Scripts.Skiirama.Core.Common.State;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.UI
{

    public class UIStateManager : MonoBehaviour
    {
        public UIState CurrentState;
        public UIState PreviousState { get; private set; }

        private readonly Dictionary<UIState, Action> stateHandlers = new();

        public UIState GetCurrentState()
        {
            return CurrentState;
        }

        void Awake()
        {
            stateHandlers.Add(UIState.ShowLoading, UIStateEvents.InvokeShowLoadingStateEvent);
            stateHandlers.Add(UIState.Loading, UIStateEvents.InvokeLoadingStateEvent);
        }

        public void SetShowLoading()
        {
            SetState(UIState.ShowLoading);
        }

        public void SetLoading()
        {
            SetState(UIState.Loading);
        }

        private void SetState(UIState newState)
        {
            if (CurrentState == newState)
            {
                Debug.LogWarning("State already set to: " + CurrentState);
                return;
            }

            PreviousState = CurrentState;
            CurrentState = newState;
            Debug.LogFormat("{0}: Set UI STATE from: '{1}' to state: '{2}'", name, PreviousState, CurrentState);

            if (!stateHandlers.ContainsKey(CurrentState))
            {
                Debug.LogWarning("No event handler for UI state: " + CurrentState);
                return;
            }

            stateHandlers[CurrentState]();

            if (MessageBus.IsSubscribed(CurrentState))
            {
                MessageBus.TriggerEvent(CurrentState);
            }
        }
    }
}
