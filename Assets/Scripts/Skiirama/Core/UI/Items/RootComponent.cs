using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.UI.Items
{
    public class RootComponent : AbstractComponent
    {
        [SerializeField]
        private MainMenuComponent mainMenuComponent;

        internal void ShowMainMenu()
        {
            Debug.Log("Show main menu.");
            //mainMenuComponent.FadeIn();
        }
        
        public void OnFadeOutAnimationEvent()
        {
            Debug.Log("Fade out animation event handler.");
            Hide();
        }
    }
}