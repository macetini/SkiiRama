using System;
using NUnit.Framework;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.UI.Common
{
    [RequireComponent(typeof(Animator))]
    public class FadableComponent : AbstractComponent
    {
        public event Action FadeOutAnimationFinishedEvent = delegate { };
        public event Action FadeInAnimationFinishedEvent = delegate { };

        private const string FADE_IN_TRIGGER = "FadeIn";
        private const string FADE_OUT_TRIGGER = "FadeOut";

        public bool Animating { get; private set; } = false;

        private Animator animator;

        void Awake()
        {
            animator = GetComponent<Animator>();
        }

        internal void FadeIn()
        {
            Debug.LogFormat("'{0}' animation for '{1}' component started.", FADE_IN_TRIGGER, name);
            Animating = true;
            animator.SetTrigger(FADE_IN_TRIGGER);
        }

        internal void OnFadeInAnimationFinished()
        {
            Animating = false;

            bool fadedIn = animator.GetCurrentAnimatorStateInfo(0).IsName(FADE_IN_TRIGGER);
            Assert.IsTrue(fadedIn, "Unexpected animation state after FadeIn.");

            Debug.LogFormat("'{0}' animation for '{1}' component finished.", FADE_IN_TRIGGER, name);
            FadeInAnimationFinishedEvent.Invoke();
        }

        internal void FadeOut()
        {
            Debug.LogFormat("'{0}' animation for '{1}' component started.", FADE_OUT_TRIGGER, name);
            Animating = true;
            animator.SetTrigger(FADE_OUT_TRIGGER);
        }

        internal void OnFadeOutAnimationFinished()
        {
            Animating = false;

            bool fadedIn = animator.GetCurrentAnimatorStateInfo(0).IsName(FADE_OUT_TRIGGER);
            Assert.IsTrue(fadedIn, "Unexpected animation state after FadeOut.");

            Debug.LogFormat("'{0}' animation for '{1}' component finished.", FADE_OUT_TRIGGER, name);
            FadeOutAnimationFinishedEvent.Invoke();
        }
    }
}