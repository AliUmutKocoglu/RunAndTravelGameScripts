using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    [SerializeField] private Toggle muteToggle;
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Mute"))
        {
            PlayerPrefs.SetInt("Mute", 0);
        }
        else
        {
            LoadMuteTaggle();
        }
    }
    private void LoadMuteTaggle()
    {
        muteToggle.isOn = PlayerPrefs.GetInt("Mute") == 1;
    }


    public void MuteToggle()
    {
        PlayerPrefs.SetInt("Mute", muteToggle.isOn ? 1 : 0);
        if(muteToggle.isOn)
        {
            AudioListener.pause = true;
        }
        else
        {
            AudioListener.pause = false;
        }
    }
}
