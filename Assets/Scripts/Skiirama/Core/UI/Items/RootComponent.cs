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

        internal void ShowMainMenu()
        {
            Debug.Log("Show main menu.");
            //mainMenuComponent.FadeIn();
        }
    }
}