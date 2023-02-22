using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PumpO : MonoBehaviour, IDropHandler
{
    public GameManager gm;

    public GameObject oxygenPacket;
    public GameObject makePacket;
    public GameObject posPacket;
    private int flag = 0;

    float amountPacket = 3;
    //Detect collisions between the GameObjects with Colliders attached
    public bool dropped = false;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("Gm").GetComponent<GameManager>();
        posPacket.transform.position = makePacket.transform.position;
    }

    private void Update()
    {

        if (oxygenPacket == null && flag != 1)
        {
            StartCoroutine(increaser());
        }


    }
    //Detect collisions between the GameObjects with Colliders attached
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
                Object.Destroy(oxygenPacket);
                StartCoroutine(packetReload());
                dropped = false;
                StartCoroutine(packetLoad());
                amountPacket--;
            }

        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Oxygen placed");

        isDropped();
    }

    public IEnumerator packetReload()
    {
        yield return new WaitForSeconds(5f);

        flag = 1;
        makePacket.transform.position = posPacket.transform.position;
        makePacket.SetActive(true);
    }

    public IEnumerator packetLoad()
    {
        yield return new WaitForSeconds(0.3f);

        flag = 0;
        makePacket.SetActive(false);

    }

    public IEnumerator increaser()
    {
        yield return new WaitForSeconds(0.3f);

        gm.oTwo += 0.002f;
    }
}

