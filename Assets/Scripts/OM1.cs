using UnityEngine;

public class ObstacleM : MonoBehaviour
{
    public float speed;
    public float distance;

    private Vector3 SP;
    void Start()
    {
        SP = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, distance);
        transform.position = SP + new Vector3(offset, 0, 0);
    }
}
