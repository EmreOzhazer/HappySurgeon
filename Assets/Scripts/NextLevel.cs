using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    public int nextSeceneLoad;
    // Start is called before the first frame update
    void Start()
    {
        nextSeceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void passNext()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Debug.Log("YouWin");
        }
        else
        {
            SceneManager.LoadScene(nextSeceneLoad);

            if (nextSeceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSeceneLoad);
            }
        }
      
    }
}
