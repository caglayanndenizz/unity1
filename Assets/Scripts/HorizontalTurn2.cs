using UnityEngine;

public class HorizontalTurn2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(1, 0, 0);
        transform.Rotate(vector * speed);

    }
}
