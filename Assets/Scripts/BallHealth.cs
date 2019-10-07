using UnityEngine;

public class BallHealth : MonoBehaviour
{
    public int maxFallDistance = -1;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= maxFallDistance)
        {
            gameManager.Restart();
        }
    }

}
