using Assets.Scripts.Skiirama.Core.Managers.UI;
using Assets.Scripts.Skiirama.Core.UI.Common;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.UI.Items
{
    public class RootComponent : FadableComponent
    {
        [SerializeField]
        internal LoadingComponent loadingComponent;

        [SerializeField]
        internal FadableComponent mainMenuComponent;

        void OnEnable()
        {
            loadingComponent.FadeInAnimationFinishedEvent += UIEvents.InvokeLoadingComponentShowAnimationEnd;
        }

        void OnDisable()
        {
            loadingComponent.FadeInAnimationFinishedEvent -= UIEvents.InvokeLoadingComponentShowAnimationEnd;
        }

        internal void ShowLoadingComponent()
        {
            Debug.LogFormat("{0}: {1}", name, "Showing Loading Component.");
            loadingComponent.FadeIn();
        }
    }
}