using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Ball;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - Ball.transform.position;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A / D
        float vertical = Input.GetAxis("Vertical");     // W / S

        Vector3 vector = new Vector3(horizontal, 0, vertical);

        transform.position = Ball.transform.position + offset;

        
        
    }
}
