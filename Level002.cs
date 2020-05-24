using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level002 : MonoBehaviour
{

    void Start()
    {
        ///when the level is finished the player will be redirected to the next level
        RedirectToLevel.redirectToLevel = 4;
        RedirectToLevel.nextLevel = 5;
    }

}
