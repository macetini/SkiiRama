using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.UI.Common
{
    public abstract class AbstractComponent : MonoBehaviour
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