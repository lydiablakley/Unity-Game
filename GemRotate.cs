using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    /// the gem will rotate at a speed of two. As this is a whole number it is defined as an interger rather than a float.
    public int rotateSpeed = 2;
  
    void Update()
    {
      transform.Rotate (0, rotateSpeed * Time.timeScale, 0, Space.World);  
    }
}

