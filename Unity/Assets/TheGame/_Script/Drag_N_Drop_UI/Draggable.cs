using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    // Variable to store the offset when we click an object form every point
    private Vector2 offset;


    // Called when the object starts to being dragged
    public void OnBeginDrag(PointerEventData eventData)
    {
        offset.x = this.transform.position.x - eventData.position.x;
        offset.y = this.transform.position.y - eventData.position.y;
    }

    // Called when the object is being dragged
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position + offset;
    }

    // Called when the object finishes of being dragged
    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
