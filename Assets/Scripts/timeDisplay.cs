using UnityEngine;
using TMPro; // TextMeshPro kullanabilmek i�in

public class timeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Ekrandaki yaz� alan�
    private float timer = 0f;         // Zaman� tutan de�i�ken
    private bool isRunning = true;    // Saya� �al���yor mu?

    void Update()
    {
        if (isRunning)
        {
            timer += Time.deltaTime; // Her karede ge�en s�reyi ekle

            // Zaman� dakika:saniye format�nda g�stermek i�in
            int minutes = Mathf.FloorToInt(timer / 60);        // Dakikay� bul
            int seconds = Mathf.FloorToInt(timer % 60);        // Saniyeyi bul
            timerText.text = $"{minutes:00}:{seconds:00}";     // Yaz�y� g�ncelle
        }
    }
}
