using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject button;

    public float Health = 100f;
    public float oTwo = 100f;
    public int infoFlag = 0;
    bool gameStarted = false;

    private bool GameFinish;

    TableManager tb;

    private float time;
    // Start is called before the first frame update
    private void Start()
    {
        time = 0f;
        tb = FindObjectOfType<TableManager>();
        //button.SetActive(false);
    }

    private void Update()
    {
        if (gameStarted == true)
        {
            if (!GameFinish)
            {
                if (infoFlag == 0)
                {
                    Health -= 0.0015f;
                    oTwo -= 0.0020f;
                }
                else if (infoFlag == 1)
                {
                    Health -= 0.0015f;
                    oTwo -= 0.0015f;
                }
                else if (infoFlag == 2)
                {
                    Health -= 0.0007f;
                    oTwo -= 0.0012f;
                }
                else if (infoFlag >= 3)
                {
                    Health -= 0.0003f;
                    oTwo -= 0.0009f;
                }
                else if (infoFlag >= 4)
                {
                    Health -= 0.0001f;
                    oTwo -= 0.0005f;
                }
                time += Time.deltaTime;
            }
            if (Health <= 0f)
            {
                Health = 0f;
            }
            if (oTwo <= 0f)
            {
                oTwo = 0f;
            }
            if (oTwo <= 0f || Health <= 0f)
            {
                GameFinish = true;
                Debug.Log("The surgery has been unsuccessful, your patient has died.");
                Debug.Log("Your time was: " + time);
            }
            if(tb.casesNumber == infoFlag)
            {
                GameFinish = true;
                Debug.Log("Operation succesfully completed.");
                Debug.Log("Your time was: " + time);
            }

        }

    }
    public void buttonVisible()
    {
        //button.SetActive(true);
    }

    public void gameWorking()
    {
        Debug.Log("Game Started..");

        gameStarted = true;

    }
}
