using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class UpgradedItem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    NewUpgradeer1 newUpgradeer;
    [SerializeField]private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
private void Start() {
    newUpgradeer = FindObjectOfType<NewUpgradeer1>();
}
    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
     public void OnDrag(PointerEventData eventData){
       // Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        newUpgradeer.buttonNotVisible();
    }
      public void OnBeginDrag(PointerEventData eventData){
        //Debug.Log("OnBeginDrag");
        canvasGroup.blocksRaycasts = false;
    }
      public void OnEndDrag(PointerEventData eventData){
        //Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
    }
    public void OnPointerDown(PointerEventData eventData){
        //Debug.Log("OnPointerDown");
    }

   
}
