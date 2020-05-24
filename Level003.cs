using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level003 : MonoBehaviour
{

    void Start()
    {
        ///when the level is finished the player will be redirected to the next level
        RedirectToLevel.redirectToLevel = 5;
        
        ///as this is currently the last level the user will then be redirected to the main menu
        RedirectToLevel.nextLevel = 1;
    }

}
