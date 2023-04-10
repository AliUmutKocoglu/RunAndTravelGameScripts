using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChepterNorway : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public void menu()
    {
        SceneManager.LoadScene(8);
        ScoreManager.instance.RemovePoint();
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
}
