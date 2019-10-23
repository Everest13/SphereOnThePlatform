using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Rigidbody playerRb;
    public float bounceAmount = 10f;
    public Transform deathParticles;

    public Animator enemyAnimator;
    private Animator centerAnimator;
    public Transform colliders;
    public GameObject enemyCenter;
    public AudioSource enemyDieSound;

    private void Awake()
    {
        centerAnimator = transform.GetComponent<Animator>();
    }

    public void Die()
    {
        playerRb.velocity = new Vector3(playerRb.velocity.x, bounceAmount, playerRb.velocity.z);
        Instantiate(deathParticles, enemyAnimator.transform.position, enemyAnimator.transform.rotation);

        enemyDieSound.Play();

        enemyAnimator.SetTrigger("Die");
        centerAnimator.SetTrigger("Stop");
        //that's is body doesnt't move
        enemyCenter.GetComponent<Animator>().enabled = false;
        Destroy(colliders.gameObject);
    }
}
