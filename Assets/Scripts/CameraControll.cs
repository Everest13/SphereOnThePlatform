using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform ball;
    public int distance = -10;
    public float lift = 1.5f;
    public Vector3 offset;

    // Set setting that camera following by ball
    void Update()
    {
        offset.Set(0, lift, distance);
        transform.position = ball.position + offset;

        //каждый кадр камера обращена к ball
        transform.LookAt(ball);
    }
}
