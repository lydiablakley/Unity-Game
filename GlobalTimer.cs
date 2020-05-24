using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    
    public GameObject timeDisplay01;
    public bool isTakingTime = false;
    /// 150 seconds is specified which is the time that is allowed to complete level 1
    public int theSeconds = 150;
    
    void Update()
    {
          /// the following if statement means if the game is running the startcoroutine will take one second away from the timer each second. 
   
      if (isTakingTime == false) {
          StartCoroutine(SubtractSecond());
      }  
    }
    
    IEnumerator SubtractSecond () {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
        
        //Doesnt run every frame as we are stopping and waiting for it to run again
    }
}

