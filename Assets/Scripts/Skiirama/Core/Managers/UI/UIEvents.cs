using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.UI
{
    public class UIEvents : MonoBehaviour
    {
        internal delegate void UIEvent();

        internal static event UIEvent ShowLoadingAnimationEvent;
        internal static void InvokeShowLoadingAnimationEvent()
        {
            Debug.LogFormat("{0}: {1}", nameof(UIEvents), "Invoking: ShowLoadingAnimationEvent.");
            ShowLoadingAnimationEvent?.Invoke();
        }

        internal static event UIEvent LoadingAnimationFinishedEvent;
        internal static void InvokeLoadingComponentShowAnimationEnd()
        {
            Debug.LogFormat("{0}: {1}", nameof(UIEvents), "Invoking: LoadingAnimationFinishedEvent.");
            LoadingAnimationFinishedEvent?.Invoke();
        }
    }
}
