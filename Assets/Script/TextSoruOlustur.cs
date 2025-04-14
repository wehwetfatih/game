
using TMPro;
using UnityEngine;

public class TextSoruOlustur : MonoBehaviour
{
    public TextMeshProUGUI sayiText;

    void Start()
    {
        // Baþlangýçta rastgele bir sayý ata
        UpdateSayi();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            UpdateSayi();
        }
    }

    void UpdateSayi()
    {
        int randomSayi = Random.Range(1, 101); // 1 ile 100 arasý sayý
        sayiText.text = "Sayý : " + randomSayi;
    }
}
