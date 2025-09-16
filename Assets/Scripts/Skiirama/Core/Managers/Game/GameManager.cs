using Assets.Scripts.Skiirama.Core.Loaders;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers.Game
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private GameStateManager gameStateManager;

        [SerializeField]
        private SceneLoader sceneLoader;

        void Awake()
        {
            //sceneLoader.LoadMainMenuScene();            
        }

        void Start()
        {
            Initialize();
        }

        public void Initialize()
        {
            gameStateManager.SetMain();
        }
    }
}