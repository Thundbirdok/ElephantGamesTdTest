namespace interactions
{
    using System;
    using UnityEngine;

    public class SpriteButton : MonoBehaviour, IInteractable
    {
        public event Action OnClick; 
        
        public void Interact() => OnClick?.Invoke();
    }
}
