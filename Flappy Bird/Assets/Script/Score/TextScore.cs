using UnityEngine;
using UnityEngine.UI;
public class TextScore : MonoBehaviour
{
    Text textScore;
    void Start()
    {
        textScore = GetComponent<Text>();
    }

    void Update()
    {
        textScore.text = Score.score.ToString();
    }
}
