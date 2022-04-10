 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Switches scene to survival
    public void PlaySurvival()
    {
        SceneManager.LoadScene("Map");
        Time.timeScale = 1f;
    }
    //switches scene to extraction
    public void PlayExtraction()
    {
        SceneManager.LoadScene("SkyIsland");
        Time.timeScale = 1f;
    }
    //Quits game and if not in build puts quit in console
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
