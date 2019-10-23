using UnityEngine;
using UnityEngine.UI;

public class FinalScoreGUI : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        scoreText.text = "SCORE: " + GameManager.finalScores;
    }
}

