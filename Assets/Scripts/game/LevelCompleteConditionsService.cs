using UnityEngine;

namespace game
{
    using interactions;

    public class LevelCompleteConditionsService : MonoBehaviour
    {
        [SerializeField]
        private SpriteButton completeLevel;

        [SerializeField]
        private LevelStateHandler levelStateHandler;
        
        private void OnEnable() => completeLevel.OnClick += CompleteLevel;

        private void OnDisable() => completeLevel.OnClick -= CompleteLevel;

        private void CompleteLevel() => levelStateHandler.CompleteLevel();
    }
}
