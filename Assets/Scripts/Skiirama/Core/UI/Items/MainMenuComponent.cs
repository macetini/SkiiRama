using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.UI.Items
{
    [RequireComponent(typeof(Animator))]
    public class MainMenuComponent : MonoBehaviour
    {
        private Animator animator;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        internal void FadeIn()
        {
            Debug.Log("FadeIn Main Menu animation started.");
            animator.SetTrigger("FadeIn");
        }
    }
}