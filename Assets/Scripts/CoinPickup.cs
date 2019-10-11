using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public Collider ball;
    public Transform coinEffect;
    private int waitDestroy = 3;
    public GameManager gameManager;
    public int coinValue = 1;

    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == ball.tag)
        {
            //add coint counter
            gameManager.currentScore += coinValue;

            //destroy checking coin
            var effect = Instantiate(coinEffect, transform.position, transform.rotation);
            Destroy(effect.gameObject, waitDestroy);
            Destroy(gameObject);
        }
    }
}
