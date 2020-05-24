using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// both UnityEngine.UI and UnityEngine.Scenemanagement are needed as UI elements are used and the user will also redirected to a new level in this script.
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    /// specifying the levelMusic which is needed to be turned off in this script.
    public GameObject levelMusic;
    public AudioSource levelComplete;
    /// specifying the timer and scores which are used in this script.
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    
    /// OnTriggerEnter means when the player - Robot Kyle - triggers a certain GameObject.
    void OnTriggerEnter()
    {
        /// the current score will be displayed.
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        
        /// the total score will be calculated and then displayed.
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        
        /// the music and time will then stop
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        
        levelComplete.Play();
        
        /// this starts the score calculation function which is in more detail below.
        StartCoroutine(CalculateScore());
    }
    
    IEnumerator CalculateScore()
    {
        /// the timeLeft will then be displayed to the user which is currently default 0 as the level has ended. 
        timeLeft.SetActive(true);
        
        /// 0.25 second wait before the score appears.
        yield return new WaitForSeconds(0.25f);
        
        /// the users current score will the be displayed.
        theScore.SetActive(true);
        
        /// 0.25 second wait before the total score appears.
        yield return new WaitForSeconds(0.25f);
        
        /// the users total score will then be displayed.
        totalScore.SetActive(true);
        
        /// 2.25 second wait.
        yield return new WaitForSeconds(0.25f);
            
         yield return new WaitForSeconds(2);
        
        /// the user will then be redirected to the next level which can be found in the build settings.
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
