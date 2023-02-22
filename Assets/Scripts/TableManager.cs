using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableManager : MonoBehaviour
{
    BoxCollider collider1;
    string colliderName;
    public int casesNumber=0;
    // Start is called before the first frame update
    void Start()
    {
        collider1 = GetComponent<BoxCollider>();
        StartCoroutine(tableLost());
    }

   

    public void OnTriggerEnter(Collider collider)
    {

        //
        //Debug.Log("Damaged Touched.");

        colliderName = collider.name;
        Debug.Log(colliderName);


        if (colliderName == "RibsBoneDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "TorsoBoneDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "PelvisBoneDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "UpperRightLegDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "UpperLeftLegDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "LowerLeftLegDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "LowerRightLegDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "RightHandDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "LeftHandDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "LowerRightArmDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "LowerLeftArmDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "UpperRightArmDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "UpperLeftArmDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "LeftFootDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "RightFootDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }
        if (colliderName == "SkullDamaged")
        {
            casesNumber++;
            Debug.Log("Cases number has been increased.");
            Debug.Log(casesNumber);
        }

        //colliderName = collider.name;
        //Debug.Log(colliderName);

    }

    IEnumerator tableLost()
    {
        yield return new WaitForSeconds(1);
        collider1.enabled = !collider1.enabled;
        
    }
}
