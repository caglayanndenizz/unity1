using UnityEngine;
using TMPro; // TextMeshPro kullanabilmek için

public class timeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Ekrandaki yazý alaný
    private float timer = 0f;         // Zamaný tutan deðiþken
    private bool isRunning = true;    // Sayaç çalýþýyor mu?

    void Update()
    {
        if (isRunning)
        {
            timer += Time.deltaTime; // Her karede geçen süreyi ekle

            // Zamaný dakika:saniye formatýnda göstermek için
            int minutes = Mathf.FloorToInt(timer / 60);        // Dakikayý bul
            int seconds = Mathf.FloorToInt(timer % 60);        // Saniyeyi bul
            timerText.text = $"{minutes:00}:{seconds:00}";     // Yazýyý güncelle
        }
    }
}
