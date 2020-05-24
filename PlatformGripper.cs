using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    /// defining theLedge which is the moving platform and thePlayer which is Robot Kyle
  public GameObject theLedge;
  public GameObject thePlayer;
    
    ///When Robot Kyle triggers theLedge it will transform with them therefore he stays on it and moves along with it.
    void OnTriggerEnter()
    {
        thePlayer.transform.parent = theLedge.transform;
    }
    
    void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
    }
}
