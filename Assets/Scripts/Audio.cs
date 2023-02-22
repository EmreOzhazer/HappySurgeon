using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour

    
{
    //public GameObject soundON;
    //public GameObject soundOFF;
    //[SerializeField] AudioSource music;


    static AudioSource audioSrc;
    public static AudioClip pointearnedSound;
   

    private void Start()
    {
        pointearnedSound = Resources.Load<AudioClip>("pointearned");

        audioSrc = GetComponent<AudioSource>();
    }
    
    public  static void UpgraderSound(string clip)
    {
        switch (clip)
        {
            case "pointearned":
                
                audioSrc.PlayOneShot(pointearnedSound);
                break;
        }
    }





    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
           
            
        }
        else
        {
            AudioListener.volume = 1f;
           
        }
    }


}
