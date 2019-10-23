using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static Vector3 ReachedPoint;
    public GameObject player;

    private void OnTriggerEnter(Collider collider)
    {
        //Save position to player, if it touch CheckPoint object
        if (collider.tag == player.tag && transform.position.x > ReachedPoint.x)
        {
            ReachedPoint = transform.position;
        }
    }
}
