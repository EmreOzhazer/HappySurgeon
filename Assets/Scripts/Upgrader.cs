using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Upgrader : MonoBehaviour
{
    GameManager gameManager;
    
    // Storing different levels'
    public GameObject[] levels;
    // Counting current level
    int current_level = 0;
     //ItemSlot itemSlot;


IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(2);
    }



    public void Upgrade(){
        
       // button.SetActive(true);

        // Check if we're safe to upgrade (We haven't reached the last level)
        if(current_level < levels.Length - 1 ){
            // Increase current level
            
            current_level++;
            // Switch to the updated level
            SwitchObject(current_level);
        }
      
    }



   public void SwitchObject(int lvl){
        
        // Count from zero the last level in our array
        for (int i = 0; i < levels.Length; i++){
            
            // Check if we're in the desired level, then activate
            if (i == lvl)
                
                levels[i].SetActive(true);
            
                
            else
           
                //Otherwise, hdie it
                levels[i].SetActive(false);
                
        
        }
    }
}
