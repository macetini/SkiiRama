using Assets.Scripts.Skiirama.Core.Common.Events;
using Assets.Scripts.Skiirama.Core.Common.State;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.EventsHandlers
{
    public class UIEventsHandler : MonoBehaviour
    {
        [SerializeField]
        private UIManager uiManager;

        void OnEnable()
        {
            GameStateEvents.OnMainStateEvent += HandleMainStateEvent;
        }

        void OnDisable()
        {
            GameStateEvents.OnMainStateEvent -= HandleMainStateEvent;
        }

        private void HandleMainStateEvent()
        {
            Debug.LogFormat("{0} : {1}", name, GameState.Main);
            uiManager.MainStateEventHandler();
        }

    }
}