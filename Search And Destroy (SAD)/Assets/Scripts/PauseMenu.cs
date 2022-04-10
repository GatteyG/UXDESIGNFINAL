using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }else
            {     
                Pause();
            }
            
        }
    } 
    //Resumes the game and makes cursor invisible
    public void Resume ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //Pauses the game bringup up esc menu
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; 
        GameIsPaused = true;
    } 
    //Loads menu
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    //Quits game or if not in build puts quit in console
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    
}
