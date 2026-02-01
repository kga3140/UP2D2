using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MobMoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float direction;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerInput.Instance.SetHorizontal(direction);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerInput.Instance.SetHorizontal(0);
    }
}
