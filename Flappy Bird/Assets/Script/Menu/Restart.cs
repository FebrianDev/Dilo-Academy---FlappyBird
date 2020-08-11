using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Restart : MonoBehaviour
{
    private Text textScore, texthighScore;
    int highScore;

    private void Start()
    {
        textScore = GameObject.FindWithTag("MyScore").GetComponent<Text>();
        texthighScore = GameObject.FindWithTag("HighScore").GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("highscore");
        
    }
    private void Update()
    {
        print(Score.score);
        if (Bird.gameOver)
        {
            if (highScore < Score.score)
            {
                highScore = Score.score;
                PlayerPrefs.SetInt("highscore", highScore);
            }
            textScore.text = "Your Score : " + Score.score.ToString();
            texthighScore.text = "HighScore : " + highScore.ToString();
           
        }

        if (Input.GetKey(KeyCode.Q))
        {
            PlayerPrefs.DeleteKey("highscore");
        }
    }
    public void Reset()
    {
        Time.timeScale = 1f;
        Score.score = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
