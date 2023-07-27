namespace animations
{
    using System.Collections;
    using interactions;
    using Spine.Unity;
    using UnityEngine;

    public class SpineAnimationOnClick : MonoBehaviour, IInteractable
    {
        [SerializeField] 
        private SkeletonAnimation skeletonAnimation;
    
        [SerializeField]
        public AnimationReferenceAsset mainAnimation;
        
        [SerializeField]
        public AnimationReferenceAsset blinkAnimation;
    
        [SerializeField]
        public float minimumDelay = 0.15f;
    
        [SerializeField]
        public float maximumDelay = 3f;

        private const int MAIN_TRACK = 0;
        private const int BLINK_TRACK = 1;

        private bool _isMainAnimationPlaying;
        
        private IEnumerator Start () 
        {
            if (skeletonAnimation == null)
            {
                yield break;
            }

            while (true) 
            {
                skeletonAnimation.AnimationState.SetAnimation
                (
                    BLINK_TRACK,
                    blinkAnimation,
                    false
                );

                var randomDelay = Random.Range(minimumDelay, maximumDelay);

                yield return new WaitForSeconds(randomDelay);
            }
        }

        public void Interact()
        {
            if (_isMainAnimationPlaying)
            {
                return;
            }

            _isMainAnimationPlaying = true;

            skeletonAnimation.AnimationState.SetAnimation
            (
                MAIN_TRACK,
                mainAnimation,
                true
            );
        }
    }
}
