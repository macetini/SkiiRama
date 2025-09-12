using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.UI
{    
    public class AbstractComponent : MonoBehaviour
    {
        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }
    }
}