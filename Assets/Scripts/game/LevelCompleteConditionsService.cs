using UnityEngine;

namespace game
{
    using interactions;

    public class LevelCompleteConditionsService : MonoBehaviour
    {
        [SerializeField]
        private SpriteButton finishLevel;

        [SerializeField]
        private LevelStateHandler levelStateHandler;
        
        private void OnEnable() => finishLevel.OnClick += CompleteLevel;

        private void OnDisable() => finishLevel.OnClick -= CompleteLevel;

        private void CompleteLevel() => levelStateHandler.CompleteLevel();
    }
}
