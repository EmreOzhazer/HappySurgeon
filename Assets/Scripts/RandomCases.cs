using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCases : MonoBehaviour
{
    public GameObject TorsoHealth;
    public GameObject TorsoDamaged;
    public GameObject[] healthyObjects;
    public GameObject[] damagedOjbects;
    public GameObject[] ObjectsList;
    public int brokenBoneAmount;
    void Start()
    {

    }


    void Update()
    {
    }

    public void generateCases()
    {
        for (int i = 0; i < brokenBoneAmount; i++)
        {
            ObjectsList[Random.Range(0,ObjectsList.Length)].SetActive(true);
        }
        

    }


}
 // int KindsNum = Random.Range(0, 2);
        // int randomNum = 0;
        // int randomNum2 = 1;
        //
        //
        // if (KindsNum == 0)
        // {
        //     if (randomNum == 0)
        //     {
        //         int randomPart1 = Random.Range(0, 2);
        //         if (randomPart1 == 0)
        //         {
        //             Debug.Log("randpart1==0");
        //             for (int i = 0; i < 3; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //             for (int i = 4; i < 7; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //             for (int i = 1; i < 4; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //             for (int i = 5; i < 8; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //
        //
        //         }
        //         if (randomPart1 == 1)
        //         {
        //             Debug.Log("randpart1==1");
        //             for (int i = 0; i < 3; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //             for (int i = 4; i < 7; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //             for (int i = 1; i < 4; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //             for (int i = 5; i < 8; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //         }
        //     }
        //     if (randomNum2 == 1)
        //     {
        //         
        //         int randomPart2 = Random.Range(0, 2);
        //         if (randomPart2 == 0)
        //         {
        //             Debug.Log("randpart2==0");
        //             for (int i = 8; i < 11; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //             for (int i = 12; i < 16; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //             for (int i = 9; i < 12; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //             for (int i = 13; i < 16; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //         }
        //         if (randomPart2 == 1)
        //         {
        //             Debug.Log("randpart2==1");
        //             for (int i = 8; i < 11; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //             for (int i = 12; i < 16; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //             for (int i = 9; i < 12; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //             for (int i = 13; i < 16; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //         }
        //
        //     }
        // }
        // else
        // {
        //     if (randomNum == 0)
        //     {
        //         int randomPart1 = Random.Range(0, 2);
        //         if (randomPart1 == 0)
        //         {
        //             for (int i = 0; i < 8; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //             for (int i = 1; i < 9; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //         }
        //         if (randomPart1 == 1)
        //         {
        //             for (int i = 0; i < 8; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //             for (int i = 1; i < 9; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //         }
        //     }
        //     if (randomNum2 == 1)
        //     {
        //         int randomPart2 = Random.Range(0, 2);
        //         if (randomPart2 == 0)
        //         {
        //             for (int i = 8; i < 15; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //             for (int i = 7; i < 16; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //         }
        //         if (randomPart2 == 1)
        //         {
        //             for (int i = 8; i < 15; i += 2)
        //             {
        //                 damagedOjbects[i].SetActive(true);
        //             }
        //
        //             for (int i = 7; i < 16; i += 2)
        //             {
        //                 healthyObjects[i].SetActive(true);
        //             }
        //
        //         }
        //
        //     }
        // }