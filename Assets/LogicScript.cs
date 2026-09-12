using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public static int best = 0;
    public TextMeshProUGUI bestText;
    public GameObject activeScores;
    public TextMeshProUGUI scoreFinal;
    public TextMeshProUGUI bestFinal;

    public void Start() 
    { 
        bestText.text = "Best: " + best; 
    }
    public void AddScore()
    {
        playerScore++;
        scoreText.text = "Score: " + playerScore.ToString();
    }

    public void GameOver() {
        Time.timeScale = 0;
        if (playerScore > best)
        {
            best = playerScore;
        }

        bestFinal.text = "Best: " + best.ToString();
        scoreFinal.text = "Score: " + playerScore.ToString();
        //activeScores.SetActive(false);
        gameOverScreen.SetActive(true);
        
        //bestText.text = "Best: " + best.ToString();

    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

}

