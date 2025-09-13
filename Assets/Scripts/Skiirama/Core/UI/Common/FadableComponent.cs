using System;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.UI.Common
{
    [RequireComponent(typeof(Animator))]
    public class FadableComponent : AbstractComponent
    {
        public event Action FadeInAnimationFinishedEvent = delegate { };
        public event Action FadeOutAnimationFinishedEvent = delegate { };

        private const string FADE_IN_TRIGGER = "FadeIn";
        private const string FADE_OUT_TRIGGER = "FadeOut";

        public bool Animating { get; private set; } = false;

        private Animator animator;

        void Awake()
        {
            animator = GetComponent<Animator>();
        }

        internal void StartFadeInAnimation()
        {
            Debug.LogFormat("'{0}' animation for '{1}' component started.", FADE_OUT_TRIGGER, name);
            Animating = true;
            animator.SetTrigger(FADE_IN_TRIGGER);
        }

        internal void OnFadeInAnimationFinished()
        {
            Debug.LogFormat("'{0}' animation for '{1}' component finished.", FADE_OUT_TRIGGER, name);
            Animating = false;
            FadeInAnimationFinishedEvent.Invoke();
        }

        internal void StartFadeOutAnimation()
        {            
            Debug.LogFormat("'{0}' animation for '{1}' component started.", FADE_OUT_TRIGGER, name);
            Animating = true;
            animator.SetTrigger(FADE_OUT_TRIGGER);
        }

        internal void OnFadeOutAnimationFinished()
        {
            Debug.LogFormat("'{0}' animation for '{1}' component animation finished.", FADE_OUT_TRIGGER, name);
            Animating = false;
            FadeOutAnimationFinishedEvent.Invoke();
        }
    }
}