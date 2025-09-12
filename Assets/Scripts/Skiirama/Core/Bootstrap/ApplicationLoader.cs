using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Skiirama.Core.Bootstrap
{
    public class ApplicationLoader : MonoBehaviour
    {
        public TextMeshProUGUI loadingText;
        public Slider loadingSlider;

        void Start()
        {
            Debug.Log("Application started.");
            StartCoroutine(LoadAsyncScene("Application"));
        }

        IEnumerator LoadAsyncScene(string sceneName)
        {
            Debug.LogFormat("Loading Scene: '{0}'.", sceneName);

            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

            asyncLoad.allowSceneActivation = false;

            while (!asyncLoad.isDone)
            {
                float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);

                if (asyncLoad.progress >= 0.9f)
                {
                    Debug.LogFormat("Scene '{0}' 90% loaded, allowing scene activation.", sceneName);
                    asyncLoad.allowSceneActivation = true;
                }

                loadingSlider.value = progress;

                string progressText = Mathf.RoundToInt(progress * 100) + "%";
                loadingText.text = progressText;

                Debug.LogFormat("Scene load progress: {0}.", progressText);

                yield return null;
            }

            Debug.LogFormat("Scene '{0}' loaded.", sceneName);
        }
    }

}
