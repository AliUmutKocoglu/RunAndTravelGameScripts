using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public int diamondValue = 1;
    public static int score =0;
    public static int highScore = 0;

    private void Awake()
    {
        instance= this;
    }
    void Start()
    {
        scoreText.text="Coins  "+ score.ToString();
    }
    public void AddPoint()
    {
        score += diamondValue;
        scoreText.text="Coins  "+score.ToString();
    }
    public void RemovePoint()
    {
        score = 0;
        scoreText.text = "Coins  " + score.ToString();
    }
}
