using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform ball;
    public int distance = -10;
    public float lift = 2.5f;
    public Vector3 offset;

    // Set setting that camera following by ball
    void LateUpdate()
    {
        offset.Set(0, lift, distance);
        transform.position = ball.position + offset;
        transform.LookAt(ball);
    }
}
