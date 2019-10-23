using UnityEngine;

public class KillOnHit : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject player;
    private float waitBeforeRestart = 1f;

    private void OnTriggerEnter(Collider colInfo)
    {
        //Destroy player object if it triggering with enemy
        if (gameManager.isRestarting == false)
        {
            if (colInfo.tag == player.tag)
            {
                SelfDestruct selfDestruct = colInfo.GetComponent<SelfDestruct>();
                selfDestruct.Destruct();
            }
            Invoke("WaitRestart", waitBeforeRestart);
        }
    }

    private void WaitRestart()
    {
        StartCoroutine(gameManager.Restart());
    }
}
