using UnityEngine;
using UnityEngine.UI;

public class CurrentScoreGUI : MonoBehaviour
{
    public Text scoreText;
    public GameManager gameManager;

    void Update()
    {
        scoreText.text = "COINS COLLECTED: " + gameManager.currentScore.ToString();
    }
}

