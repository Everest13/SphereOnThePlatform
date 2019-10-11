using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{
    public int rotationSpeed = 200;
    public int jumpHeight = 8;
    public float distToGround;
    public Rigidbody rb;
    public Collider ball;

    public AudioSource audioData;
    public AudioClip hit01;
    public AudioClip hit02;
    public AudioClip hit03;

    private void Start()
    {
        distToGround = ball.bounds.extents.y;
    }

    // Update is called once per frame
    private void Update()
    {
        //Добавляет крутящий момент при нажатии "a"/"d" - Handle ball roration
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        rb.AddRelativeTorque(Vector3.back * rotation);

        //If ball is jumping 
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        }
    }

    //Check if we are on the ground
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        int theHit = Random.Range(0, 4);
        switch (theHit)
        {
            case 0:
                audioData.clip = hit01;
                break;
            case 1:
                audioData.clip = hit02;
                break;
            case 3:
                audioData.clip = hit03;
                break;
        }
        audioData.pitch = Random.Range(0.9f, 1.1f);
        audioData.Play();
    }
}   

