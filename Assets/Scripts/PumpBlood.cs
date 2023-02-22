using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PumpBlood : MonoBehaviour, IDropHandler
{
    public GameManager gm;

    public GameObject bloodPacket;
    public GameObject makePacketB;
    public GameObject posPacket;
    private int flag = 0;

    float amountPacket = 3;
    //Detect collisions between the GameObjects with Colliders attached
    public bool dropped = false;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("Gm").GetComponent<GameManager>();
        posPacket.transform.position = makePacketB.transform.position;
    }

    private void Update()
    {
        if (bloodPacket == null && flag != 1)
        {
            StartCoroutine(increaser());
        }
    }


    public void isDropped()
    {
        dropped = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (dropped == true)
        {
            if (eventData.pointerDrag != null)
            {
                Debug.Log("OnDrop");
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                GameObject.Destroy(bloodPacket);
                StartCoroutine(packetReload());
                dropped = false;
                StartCoroutine(packetLoad());
                amountPacket--;


            }
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Blood placed");

        isDropped();
    }

    public IEnumerator packetReload()
    {
        yield return new WaitForSeconds(5f);

        flag = 1;
        makePacketB.transform.position = posPacket.transform.position;
        makePacketB.SetActive(true);
    }

    public IEnumerator packetLoad()
    {
        yield return new WaitForSeconds(0.3f);

        flag = 0;
        makePacketB.SetActive(false);

    }

    public IEnumerator increaser()
    {
        yield return new WaitForSeconds(0.3f);

        gm.Health += 0.002f;
    }

}

