using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public Collider player;
    public Transform coinEffect;
    private int waitDestroy = 2;
    public GameManager gameManager;
    public int coinValue = 1;

    void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == player.tag)
        {
            //Increase current score 
            gameManager.currentScore += coinValue;
            //Create particles and destroy checking coin
            var effect = Instantiate(coinEffect, transform.position, transform.rotation);
            Destroy(effect.gameObject, waitDestroy);
            Destroy(gameObject);
        }
    }
}
