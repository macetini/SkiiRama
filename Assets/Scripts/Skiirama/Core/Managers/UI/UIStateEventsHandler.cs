using System;
using Assets.Scripts.Skiirama.Core.Common.State;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.UI
{
    public class UIStateEventsHandler : MonoBehaviour
    {
        void OnEnable()
        {
            UIStateEvents.OnShowLoadingStateEvent += ShowLoadingStateHandler;
        }

        void OnDisable()
        {
            UIStateEvents.OnShowLoadingStateEvent -= ShowLoadingStateHandler;
        }

        private void ShowLoadingStateHandler()
        {
            Debug.LogFormat("{0}: Handler for: '{1}' event", name, UIState.ShowLoading);
            UIEvents.InvokeShowLoadingAnimationEvent();
        }
    }
}