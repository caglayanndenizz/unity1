using UnityEngine;

public class OM3 : MonoBehaviour
{
    public float speed;
    public float height;
    private Vector3 SP;
    void Start()
    {
        SP = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       float offset =Mathf.Sin(Time.time * speed) * height;
        transform.position = SP + new Vector3(0, offset, 0);
    }
}
