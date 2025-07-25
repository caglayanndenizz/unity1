using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Phy; // Rigidbody bileşeni, topa fizik uygulamak için
    public float speed; // Hareket hızı
    public float jumpforce; // Zıplama kuvveti
    public LayerMask groundMask; // Hangi yüzeylerin zemin olduğunu belirtir
    private bool onground; // Top şu an yerde mi?

    void Start()
    {
        Phy = GetComponent<Rigidbody>(); // Rigidbody bileşenini al
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D veya ←/→
        float moveVertical = Input.GetAxis("Vertical");     // W/S veya ↑/↓

        Vector3 vector = new Vector3(moveHorizontal, 0, moveVertical); // Yatay düzlemde hareket

        Phy.AddForce(vector * speed); // Topu hareket ettirmek için kuvvet uygula
    }

    void Update()
    {
        // Aşağı doğru küçük bir ışın gönderip topun zemine değip değmediğini kontrol eder
        onground = Physics.Raycast(transform.position, Vector3.down, 1.1f, groundMask);

        // Space tuşuna basılırsa ve top yerdeyse zıpla
        if (Input.GetKeyDown(KeyCode.Space) && onground)
        {
            Phy.AddForce(Vector3.up * jumpforce, ForceMode.Impulse); // Yukarı doğru zıplama kuvveti uygula
        }
    }
}
