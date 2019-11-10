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
        Debug.Log("trigger");
        if (collInfo.tag == player.tag)
        {
            gameManager.LoadNexLevel();
        }
    }
}
