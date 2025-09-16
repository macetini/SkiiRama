using Assets.Scripts.Skiirama.Core.Common.State;
using Assets.Scripts.Skiirama.Core.UI.Items;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private UIStateManager uiStateManager;

        [SerializeField]
        private RootComponent rootComponent;

        void OnEnable()
        {
            MessageBus.Subscribe(GameState.Main, uiStateManager.SetShowLoading);

            UIEvents.ShowLoadingAnimationEvent += rootComponent.ShowLoadingComponent;            
            UIEvents.LoadingAnimationFinishedEvent += uiStateManager.SetLoading;
        }

        void OnDisable()
        {
            MessageBus.Unsubscribe(GameState.Main, uiStateManager.SetShowLoading);

            UIEvents.ShowLoadingAnimationEvent -= rootComponent.ShowLoadingComponent;
            UIEvents.LoadingAnimationFinishedEvent -= uiStateManager.SetLoading;
        }
    }
}