using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour
{

    void Start()
    {
        ///when the level is finished the player will be redirected to the next level
        RedirectToLevel.redirectToLevel = 3;
        RedirectToLevel.nextLevel = 4;
    }

}
