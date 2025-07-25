using UnityEngine;

public class OM2 : MonoBehaviour
{
    public float rotationspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationspeed * Time.deltaTime);
    }
}
