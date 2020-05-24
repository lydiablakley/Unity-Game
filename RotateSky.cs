using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    
/// the speed has to be a float as it is not a whole number, if the speed was a whole number it would be public int rotateSpeed.
    
    public float rotateSpeed = 1.2f;

    // Update is called once per frame
    void Update()
    {
        
        ///skybox is selected with the rotation element at the selected rotatespeed which is specified above.
        
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}



