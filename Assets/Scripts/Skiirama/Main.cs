using Assets.Scripts.Skiirama.Core.Loaders;
using Assets.Scripts.Skiirama.Core.Managers;
using UnityEngine;

namespace Assets.Scripts.Skiirama
{
    public class Main : MonoBehaviour
    {
        [SerializeField]
        private GameStateManager gameStateManager;

        [SerializeField]
        private SceneLoader sceneLoader;

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
