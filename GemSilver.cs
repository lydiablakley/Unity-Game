using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{
/// this adds our scoreBox into the script which is then referenced below to allow us to alter it.
    public GameObject scoreBox;
    
/// this is adding our audio collectSound into the script to then be referenced below.
    public AudioSource collectSound;
    
/// OnTriggerEnter means when the player Robo Kyle collides with another gameObject, in this case it will be the GemSilver.
    void OnTriggerEnter()
    {
        /// when the player triggers the gem the score will increase by 1000.
        GlobalScore.currentScore += 1000;
        
        /// this will play the collectSound when the player collides with the GemSilver gameObject.
        collectSound.Play();
        
        /// this will destory the gameObject GemSilver when the player collides with it. 
        Destroy(gameObject);
    }
}
