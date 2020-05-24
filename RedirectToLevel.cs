using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
  
    public static int redirectToLevel;
    public static int nextLevel;
    
/// this function redirects the user to level 3 which is the redirectlevel scene. Which then takes them back to the start of their scene.
    
    void Update()
    {
     if (redirectToLevel == 3) 
     {
         SceneManager.LoadScene(redirectToLevel);
     }
    }
}

