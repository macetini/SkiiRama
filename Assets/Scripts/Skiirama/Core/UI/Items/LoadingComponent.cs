using Assets.Scripts.Skiirama.Core.UI.Common;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Skiirama.Core.UI.Items
{
    public class LoadingComponent : FadableComponent
    {
        [SerializeField]
        private TextMeshProUGUI loadingText;

        [SerializeField]
        private Slider loadingSlider;

        public string ProgressText
        {
            set
            {
                loadingText.text = value;
            }
        }

        public float SliderProgress
        {
            set
            {
                loadingSlider.value = value;
            }
        }
    }
}