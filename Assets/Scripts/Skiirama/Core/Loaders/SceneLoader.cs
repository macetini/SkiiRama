using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Skiirama.Core.Loaders
{
    public class SceneLoader : MonoBehaviour
    {
        public int CurrentLevelIndex { get; private set; } = -1;

        [SerializeField]
        private string sceneNamePrefix = "Level_";

        [SerializeField]
        private int levelCount = 1;

        public void LoadMainMenuScene()
        {
            CurrentLevelIndex = 0;
            LoadLevelSceneAdditive("MainMenu"); //"CurrentLevelIndex);
        }

        public void LoadNextLevel()
        {
            if (CurrentLevelIndex >= levelCount)
            {
                CurrentLevelIndex = 0;
                Debug.Log("All levels completed. Starting over from level 1.");
            }

            CurrentLevelIndex++;
            Debug.Log("Loading level " + CurrentLevelIndex);
            LoadScene(CurrentLevelIndex);
        }

        private void LoadScene(int levelIndex)
        {
            if (levelIndex > levelCount)
            {
                CurrentLevelIndex = levelIndex;
                throw new System.Exception("Level index out of range!");
            }

            string levelSceneName = sceneNamePrefix + levelIndex;
            LoadLevelSceneAdditive(levelSceneName);
        }

        private void LoadLevelSceneAdditive(string levelSceneName)
        {
            if (!SceneManager.GetSceneByName(levelSceneName).isLoaded)
            {
                StartCoroutine(LoadSceneAsyncCoroutine(levelSceneName));
            }
        }

        private static IEnumerator LoadSceneAsyncCoroutine(string sceneName)
        {
            Debug.Log("Loading scene: " + sceneName);

            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

            while (!asyncLoad.isDone)
            {
                Debug.Log("Scene loading progress: " + asyncLoad.progress);
                yield return null;
            }

            //SceneEventsManager.InvokeSceneLoadedEvent(sceneName);
        }
    }
}
