using UnityEngine;

namespace interactions
{
    public class InteractionClickService : MonoBehaviour
    {
        [SerializeField]
        private Camera raycastCamera;
        
        private void Update() => Check2DObjectClicked();

        private void Check2DObjectClicked()
        {
            if (Input.GetMouseButtonDown(0) == false)
            {
                return;
            }
            
            GetRayOriginAndDirection(out var origin, out var direction);

            var hit = Physics2D.Raycast(origin, direction);

            if (!hit)
            {
                return;
            }

            if (hit.collider.TryGetComponent(out IInteractable interactable))
            {
                interactable.Interact();
            }
        }

        private void GetRayOriginAndDirection(out Vector2 origin, out Vector2 direction)
        {
            if (raycastCamera.orthographic)
            {
                origin = raycastCamera.ScreenToWorldPoint(Input.mousePosition);
                direction = Vector2.zero;
                
                return;
            }

            var ray = raycastCamera.ScreenPointToRay(Input.mousePosition);
            origin = ray.origin;
            direction = ray.direction;
        }
    }
}
