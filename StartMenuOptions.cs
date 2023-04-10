using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuOptions : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject optionsMenu;
    public GameObject panel;
    public AudioSource them;
    public GameObject howToPlay;
    public void ShowOptions()
    {
        optionsMenu.SetActive(true);
        panel.SetActive(true);
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
    public void HowToPlay()
    {
        panel.SetActive(true);
        howToPlay.SetActive(true);
    }
}
