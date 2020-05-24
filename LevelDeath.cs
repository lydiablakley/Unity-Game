using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject levelAudio;
    public GameObject fadeOut;
    
    void OnTriggerEnter()
    {
        /// when the player collides with the cube which is underneath all the platforms the YouFellOff function will be activated.
        StartCoroutine(YouFellOff());
    }
  
    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        levelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        
        /// when the user dies then the current score will be refreshed back to 0.
        GlobalScore.currentScore = 0;
        
        ///goes back to current level we are on
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
        
    
    }
    
}
