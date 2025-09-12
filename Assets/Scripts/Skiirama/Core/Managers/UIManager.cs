using Assets.Scripts.Skiirama.Core.UI.Items;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private RootComponent rootComponent;

        internal void MainStateEventHandler()
        {
            Debug.LogFormat("{0} : Main State Event Handler", name);            
            rootComponent.ShowMainMenu();
        }
    }
}