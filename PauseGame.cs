using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
  ///boolean cause be used for true or false responses
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    
    void Update()
    {
        /// if cancel is pressed which unity knows is the esc key the pause menu will show, the timer will stop, the levelMusic will pause and the cursor will become visible.
       if (Input.GetButtonDown("Cancel")){
           if(gamePaused == false) {
               Time.timeScale = 0;
               gamePaused = true;
               Cursor.visible = true;
               levelMusic.Pause();
               pauseMenu.SetActive(true);
           }
           
           else {
               pauseMenu.SetActive(false);
               levelMusic.UnPause();
               Cursor.visible = false;
               gamePaused = false;
               Time.timeScale = 1;
           }
       } 
    }
    
    public void ResumeGame()
    {
        /// if the user presses the resume button everything currently set above will be undone.
         pauseMenu.SetActive(false);
               levelMusic.UnPause();
               Cursor.visible = false;
               gamePaused = false;
               Time.timeScale = 1;
    }
    
        public void RestartLevel()
    {
            /// if the restart button is pressed the music will be unpaused, the cursor will no longer be visible, the scene will load again from the start and unpause.
         pauseMenu.SetActive(false);
               levelMusic.UnPause();
               Cursor.visible = false;
               gamePaused = false;
               Time.timeScale = 1;
            SceneManager.LoadScene(2);
    }
       public void QuitToMenu()
    {
           /// if the quit button is pressed the button will stop completely, the cursor will be visible, and the scene manager then loads scene 1 which is the main menu.
         pauseMenu.SetActive(false);
               levelMusic.UnPause();
               Cursor.visible = false;
               gamePaused = false;
               Time.timeScale = 1;
            SceneManager.LoadScene(1);
    }
}
