//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class RandomCases : MonoBehaviour
//{
//    public GameObject TorsoHealth;
//    public GameObject TorsoDamaged;
//    public GameObject[] healthyObjects;
//    public GameObject[] damagedOjbects;
//    // Start is called before the first frame update
//    void Start()
//    {
//        //generateCases();
//        //Debug.Log("Its working");
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    public void generateCases()
//    {
//        int randomNum = 0;
//        int randomNum2 = 1;


//        if (randomNum == 0)
//        {
//            int randomPart1 = Random.Range(0, 2);
//            if (randomPart1 == 0)
//            {
//                for (int i = 0; i < 8; i += 2)
//                {
//                    healthyObjects[i].SetActive(true);
//                }

//                for (int i = 1; i < 9; i += 2)
//                {
//                    damagedOjbects[i].SetActive(true);
//                }

//            }
//            if (randomPart1 == 1)
//            {
//                for (int i = 0; i < 8; i += 2)
//                {
//                    damagedOjbects[i].SetActive(true);
//                }

//                for (int i = 1; i < 9; i += 2)
//                {
//                    healthyObjects[i].SetActive(true);
//                }

//            }
//        }
//        if (randomNum2 == 1)
//        {
//            int randomPart2 = Random.Range(0, 2);
//            if (randomPart2 == 0)
//            {
//                for (int i = 8; i < 15; i += 2)
//                {
//                    healthyObjects[i].SetActive(true);
//                }

//                for (int i = 7; i < 15; i += 2)
//                {
//                    damagedOjbects[i].SetActive(true);
//                }

//            }
//            if (randomPart2 == 1)
//            {
//                for (int i = 8; i < 15; i += 2)
//                {
//                    damagedOjbects[i].SetActive(true);
//                }

//                for (int i = 7; i < 15; i += 2)
//                {
//                    healthyObjects[i].SetActive(true);
//                }

//            }

//        }


//        //if (randomNum == 1)
//        //{
//        //    GameObject.Instantiate(TorsoHealth);
//        //    TorsoHealth.SetActive(true);

//        //}
//        //else
//        //{
//        //    GameObject.Instantiate(TorsoDamaged);
//        //    TorsoDamaged.SetActive(true);
//        //}


//        Debug.Log("its working");
//        Debug.Log(randomNum);

//    }


//}
