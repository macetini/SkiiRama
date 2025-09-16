using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.Game
{
    public class GameEventsHandler : MonoBehaviour
    {
        void OnEnable()
        {
            GameEvents.OnMainGameEvent += HandleMainGameEvent;
        }

        void OnDisable()
        {
            GameEvents.OnMainGameEvent += HandleMainGameEvent;
        }

        private void HandleMainGameEvent()
        {
            Debug.LogFormat("{0} : HandleMainGameEvent", name);
        }
    }
}
