using System;
using System.Collections.Generic;
using Assets.Scripts.Skiirama.Core.Common;
using Assets.Scripts.Skiirama.Core.Managers.Events;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers
{
    public class GameStateManager : MonoBehaviour
    {
        public GameState CurrentState = GameState.Quit;
        public GameState PreviousState { get; private set; }

        public bool Main => CurrentState == GameState.Main;
        public bool Start => CurrentState == GameState.Start;
        public bool Active => CurrentState == GameState.Active;
        public bool Immobile => CurrentState == GameState.Immobile;
        public bool Pass => CurrentState == GameState.Pass;
        public bool Fail => CurrentState == GameState.Fail;
        public bool Restart => CurrentState == GameState.Restart;
        public bool Transition => CurrentState == GameState.Transition;
        public bool Quit => CurrentState == GameState.Quit;

        private readonly Dictionary<GameState, Action> stateHandlers = new();

        void Awake()
        {
            stateHandlers.Add(GameState.Main, GameStateEvents.InvokeSetMainStateEvent);
            stateHandlers.Add(GameState.Start, GameStateEvents.InvokeSetStartStateEvent);
            stateHandlers.Add(GameState.Active, GameStateEvents.InvokeSetActiveStateEvent);
            stateHandlers.Add(GameState.Immobile, GameStateEvents.InvokeSetImmobileStateEvent);
            stateHandlers.Add(GameState.Pass, GameStateEvents.InvokeSetPassStateEvent);
            stateHandlers.Add(GameState.Fail, GameStateEvents.InvokeSetFailStateEvent);
            stateHandlers.Add(GameState.Restart, GameStateEvents.InvokeSetResetStateEvent);
            stateHandlers.Add(GameState.Transition, GameStateEvents.InvokeSetTransitionStateEvent);
            stateHandlers.Add(GameState.Quit, GameStateEvents.InvokeSetQuitStateEvent);

        }

        public GameState GetCurrentState()
        {
            return CurrentState;
        }

        public void SetMain()
        {
            SetState(GameState.Main);
        }

        public void SetStart()
        {
            SetState(GameState.Start);
        }

        public void SetActive()
        {
            SetState(GameState.Active);
        }

        public void SetImmobile()
        {
            SetState(GameState.Immobile);
        }

        public void SetPass()
        {
            SetState(GameState.Pass);
        }

        public void SetFail()
        {
            SetState(GameState.Fail);
        }

        public void SetRestart()
        {
            SetState(GameState.Restart);
        }

        public void SetTransition()
        {
            SetState(GameState.Transition);
        }

        public void SetQuit()
        {
            SetState(GameState.Quit);
        }

        private void SetState(GameState newState)
        {
            if (CurrentState == newState)
            {
                Debug.LogWarning("State already set to: " + CurrentState);
                return;
            }

            PreviousState = CurrentState;
            CurrentState = newState;
            Debug.Log("Set from state: " + PreviousState + " to state: " + CurrentState);

            if (!stateHandlers.ContainsKey(CurrentState))
            {
                Debug.LogWarning("No event handler for state: " + CurrentState);
                return;
            }

            stateHandlers[CurrentState]();
        }
    }
}