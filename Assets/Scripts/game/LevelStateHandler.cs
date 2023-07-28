namespace game
{
    using System;
    using UnityEngine;

    [CreateAssetMenu(fileName = "LevelStateHandler", menuName = "Level/LevelStateHandler")]
    public class LevelStateHandler : ScriptableObject
    {
        public event Action OnLevelComplete;
        
        public void CompleteLevel() => OnLevelComplete?.Invoke();
    }
}
