using Assets.Scripts.Skiirama.Core.Loaders;
using Assets.Scripts.Skiirama.Core.Managers.Events;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.EventsHandlers
{
    public class GameStateEventsHandler : MonoBehaviour
    {
        [SerializeField]
        private SceneLoader sceneLoader;

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
            Debug.Log("Main State Event Handler.");
            sceneLoader.LoadMainMenuScene();
        }

        private void HandleTransitionStateEvent()
        {
            Debug.Log("Transition State Event Handler.");
            sceneLoader.LoadNextLevel();
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
