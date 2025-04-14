
using TMPro;
using UnityEngine;

public class TextTus : MonoBehaviour
{
    public TextMeshProUGUI tusText;

    void Start()
    {
        // Baþlangýçta rastgele bir sayý ata
        UpdateTus("Tusa Bas");
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            string tus = Input.inputString.ToString();

            if (!string.IsNullOrEmpty(tus))
            {
                //Debug.Log("Basýlan Tuþ: " + tus);
                UpdateTus(tus);
            }
        }
    }

    void UpdateTus(string tus)
    {
        tusText.text = "Tus : " + tus;

    }
}
