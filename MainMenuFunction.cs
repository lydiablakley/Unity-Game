using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///the top three name spaces are already added by default. The SceneManagement name space needs to be used to use the load scene function
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    
///this brings in the AudioSource used when a button is clicked
    public AudioSource buttonPress;
    
    public void PlayGame()
    {
        ///when the play button is pressed the user will be redirected to level 3.
      buttonPress.Play();
      RedirectToLevel.redirectToLevel = 3;
      SceneManager.LoadScene(2);
    }
    
    ///when the quit button is pressed the application will quit however this will only work when a realtime game, doesn't realise that unity is the application it should close 
    public void QuitGame()
    {
        Application.Quit();
    }
    
    ///buttons are good as they will work on mobile and tablet devices without any alterations
}

