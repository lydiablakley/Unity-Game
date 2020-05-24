using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
   public GameObject theLogo;
    
    
    void Start()
    {
        /// when the game is started the splash screen will run.
       StartCoroutine(RunSplash()); 
    }
    
    IEnumerator RunSplash() {
        /// the screen will be blank for half a second
       yield return new WaitForSeconds(0.5f);
        /// the Lydia Blakley logo will then appear
        theLogo.SetActive(true);
        /// the screen will stay with the logo appeared for 4 and a half seconds
        yield return new WaitForSeconds(4.5f);
        /// Scene 1 which is the main menu will then be loaded
        SceneManager.LoadScene(1);
 
    }


}
