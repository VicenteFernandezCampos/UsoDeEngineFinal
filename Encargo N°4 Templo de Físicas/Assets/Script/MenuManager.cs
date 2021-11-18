using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject menuUI;
    public GameObject audioMenu;
    public bool goBack = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
               Pause();
            }
        }
    }
    public void Resume()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void AudioMenu()
    {
        if(goBack == false)
        {
            audioMenu.SetActive(true);
            goBack = true;
        }
        else
        {
            audioMenu.SetActive(false);
            goBack = false;
        }
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}
