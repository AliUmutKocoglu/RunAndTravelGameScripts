using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChepterGreek : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public void menu()
    {
        SceneManager.LoadScene(5);
        ScoreManager.instance.RemovePoint();
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
}
