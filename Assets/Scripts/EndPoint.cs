using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public GameObject player;
    public GameManager gameManager;

    /*
     * Load next level if level is over
     */
    private void OnTriggerEnter(Collider collInfo)
    {
        if (collInfo.tag == player.tag)
        {
            gameManager.LoadNexLevel();
        }
    }
}
