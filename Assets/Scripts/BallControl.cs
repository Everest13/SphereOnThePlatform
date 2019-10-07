using UnityEngine;

public class BallControl : MonoBehaviour
{
    public int rotationSpeed = 100;
    public int jumpHeight = 8;
    private bool isFalling = false;

    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        //Добавляет крутящий момент при нажатии "a"/"d" - Handle ball roration
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        rb.AddRelativeTorque(Vector3.back * rotation);

        //
        if (Input.GetKeyDown(KeyCode.W) && isFalling == false)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        }
        isFalling = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        isFalling = false;
    }
}   
