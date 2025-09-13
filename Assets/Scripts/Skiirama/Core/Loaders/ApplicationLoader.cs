using System.Collections;
using Assets.Scripts.Skiirama.Core.UI.Items;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Skiirama.Core.Loaders
{
    public class ApplicationLoader : MonoBehaviour
    {
        [SerializeField]
        private LoadingComponent loadingComponent;

        private AsyncOperation asyncLoad;

        private const string APPLICATION_SCENE_NAME = "Application";

        void Start()
        {
            Debug.Log("Application started.");
            StartCoroutine(LoadAsyncApplicationScene());
        }

        void OnEnable()
        {
            loadingComponent.FadeOutAnimationFinishedEvent += FadeOutAnimationFinishedEventHandler;
        }

        void OnDisable()
        {
            loadingComponent.FadeOutAnimationFinishedEvent -= FadeOutAnimationFinishedEventHandler;
        }

        private IEnumerator LoadAsyncApplicationScene()
        {
            Debug.LogFormat("Loading Scene: '{0}'.", APPLICATION_SCENE_NAME);

            asyncLoad = SceneManager.LoadSceneAsync(APPLICATION_SCENE_NAME);
            asyncLoad.allowSceneActivation = false;

            if (asyncLoad.progress < 0.9)
            {
                float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);
                loadingComponent.SliderProgress = progress;

                string progressText = Mathf.RoundToInt(progress * 100) + "%";
                loadingComponent.ProgressText = progressText;

                Debug.LogFormat("Scene load progress: {0}.", progressText);

                yield return null;
            }

            Debug.Log("Scene 90% loaded, closing animation started.");
            loadingComponent.StartFadeOutAnimation();
        }

        private void FadeOutAnimationFinishedEventHandler()
        {
            Debug.Log("Scene closing animation finished, starting next scene activation.");
            asyncLoad.allowSceneActivation = true;
        }
    }
}
