using Assets.Scripts.Skiirama.Core.Managers.Events;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.EventsHandlers
{
    public class UIEventsHandler : MonoBehaviour
    {
        void OnEnable()
        {
            //GameStateEvents.OnMainStateEvent += HandleMainStateEvent;            
        }

        void OnDisable()
        {
            //GameStateEvents.OnMainStateEvent -= HandleMainStateEvent;            
        }
    }
}