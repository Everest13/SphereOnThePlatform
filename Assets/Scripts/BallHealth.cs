using UnityEngine;

public class BallHealth : MonoBehaviour
{
    private float maxFallDistance = -15f;
    public GameManager gameManager;

    void Update()
    {
        //Restart game, if ball is fallinf from the platform
        if (transform.position.y <= maxFallDistance && gameManager.isRestarting == false)
        {
            StartCoroutine(gameManager.Restart());
        }
    }
}
