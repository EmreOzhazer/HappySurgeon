using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public string tagName;
    // public GameObject TorsoSlot;
    // public GameObject Torso;
    // public GameObject Ribs;
    // public GameObject RibsSlot;
    // public GameObject Pelvis;
    // public GameObject PelvisSlot;
    public NewUpgradeer1 newUpgradeer1;
    private void Start()
    {
        newUpgradeer1 = FindObjectOfType<NewUpgradeer1>();
    }
    public void OnDrop(PointerEventData eventData)
    {

        if (newUpgradeer1.dropped == true && eventData.pointerDrag != null)
        {

            //Debug.Log("OnDrop");
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //StartCoroutine(TimeDelay());


            switch (tagName)
            {
                case "Ribs":
                    Debug.Log("Ribstag");
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    break;

                case "Torso":
                    Debug.Log("Torsotag");
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    break;

                case "Pelvis":
                    Debug.Log("Pelvis");
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    break;
            }
        }
    }

    public void OnTriggerEnter(Collider collider)
    {

        Debug.Log("Slots Matched.");

        tagName = collider.tag;

    }

}
