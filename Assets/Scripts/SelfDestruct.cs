using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public Rigidbody rb;
    public SphereCollider ballCollider;
    public Transform piecesParent;
    public Transform piecesPrefab;
    public GameObject wholeBall;
    private float destroyTime = 5f;

    /*
     * Destruct player when it touch the enemy
     */
    public void Destruct()
    {
        rb.isKinematic = true;
        ballCollider.enabled = false;
        var clone = Instantiate(piecesPrefab, piecesParent.position, piecesParent.rotation);
        Destroy(clone.gameObject, destroyTime);
        wholeBall.SetActive(false);
    }

    /*
     * Restore player if level is restarting
     */
    public void DeDestruct()
    {
        rb.isKinematic = false;
        ballCollider.enabled = true;
        wholeBall.SetActive(true);
    }
}
