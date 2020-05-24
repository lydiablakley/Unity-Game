using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// UnityEngine.UI needed as the scoreBox which is a UI element is involved in this script.
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
  
    public GameObject scoreBox;
    public static int currentScore;
    /// the user doesnt see the internal score, this only see the current score.
    public int internalScore;
    
    void Update()
    {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;
    }
}

