using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static bool gameIsPaused=false;
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public GameObject panel;
    public AudioSource them;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
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
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused= false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void quit()
    {
        Application.Quit();
    }
    public void ShowOptions()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
        gameIsPaused = true;
    }
    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }
    public void SetFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }
    public void SetMusic(bool isMusic)
    {
        them.mute = !isMusic;
    }
}
