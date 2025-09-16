using System;
using Assets.Scripts.Skiirama.Core.UI.Common;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.UI.Items
{
    public class RootComponent : FadableComponent
    {
        [SerializeField]
        private LoadingComponent loadingComponent;

        [SerializeField]
        private FadableComponent mainMenuComponent;

        void OnEnable()
        {
            loadingComponent.FadeInAnimationFinishedEvent += LoadingFadeInFinishedEventHandler;
        }

        void OnDisable()
        {
            loadingComponent.FadeInAnimationFinishedEvent -= LoadingFadeInFinishedEventHandler;
        }

        private void LoadingFadeInFinishedEventHandler()
        {
            Debug.Log("Loading component fade in finished.");
            //loadingComponent.FadeOut();
            //mainMenuComponent.FadeIn();
        }

        internal void OnMainState()
        {
            Debug.Log("Loading component fade in.");
            loadingComponent.FadeIn();
        }
    }
}