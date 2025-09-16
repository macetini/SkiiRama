using Assets.Scripts.Skiirama.Core.Common.State;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.Game
{
    public class GameStateEventsHandler : MonoBehaviour
    {
        void OnEnable()
        {
            GameStateEvents.OnMainStateEvent += HandleMainStateEvent;
            GameStateEvents.OnTransitionStateEvent += HandleTransitionStateEvent;

            GameStateEvents.OnStartStateEvent += HandleStartStateEvent;
            GameStateEvents.OnActiveStateEvent += HandleActiveStateEvent;
            GameStateEvents.OnImmobileStateEvent += HandleImmobileStateEvent;
            GameStateEvents.OnPassStateEvent += HandlePassStateEvent;
            GameStateEvents.OnFailStateEvent += HandleFailStateEvent;
            GameStateEvents.OnResetStateEvent += HandleResetStateEvent;
            GameStateEvents.OnQuitStateEvent += HandleQuitStateEvent;
        }

        void OnDisable()
        {
            GameStateEvents.OnMainStateEvent -= HandleMainStateEvent;
            GameStateEvents.OnTransitionStateEvent -= HandleTransitionStateEvent;

            GameStateEvents.OnStartStateEvent -= HandleStartStateEvent;
            GameStateEvents.OnActiveStateEvent -= HandleActiveStateEvent;
            GameStateEvents.OnImmobileStateEvent -= HandleImmobileStateEvent;
            GameStateEvents.OnPassStateEvent -= HandlePassStateEvent;
            GameStateEvents.OnFailStateEvent -= HandleFailStateEvent;
            GameStateEvents.OnResetStateEvent -= HandleResetStateEvent;
            GameStateEvents.OnQuitStateEvent -= HandleQuitStateEvent;
        }

        private void HandleMainStateEvent()
        {
            Debug.LogFormat("{0}: {1}", name, GameState.Main);
            //MessageBus.TriggerEvent(GameState.Main);
        }

        private void HandleTransitionStateEvent()
        {
            Debug.Log("Transition State Event Handler.");
        }

        private void HandleResetStateEvent()
        {

        }

        private void HandleStartStateEvent()
        {

        }

        private void HandleActiveStateEvent()
        {

        }

        private void HandlePassStateEvent()
        {

        }

        private void HandleFailStateEvent()
        {

        }

        private void HandleImmobileStateEvent()
        {

        }

        private void HandleQuitStateEvent()
        {

        }
    }
}
