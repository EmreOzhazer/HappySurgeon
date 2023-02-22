using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{

    public void Pass(int levelIndex)
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Debug.Log("YouWin");
        }
        else
        {
            int currentLevel = SceneManager.GetActiveScene().buildIndex;

            if (currentLevel >= PlayerPrefs.GetInt("levelIsUnlocked"))

            {
                PlayerPrefs.SetInt("levelIsUnlocked", currentLevel + 1);
            }

            SceneManager.LoadScene(levelIndex);
            Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelIsUnlocked") + " UNLOCKED");
        }
     

    }
}