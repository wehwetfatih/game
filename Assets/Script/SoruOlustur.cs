using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoruOlustur : MonoBehaviour
{
    int soruSayisi = 0;

    public TextMeshProUGUI Soru_TEXT;
    public TextMeshProUGUI CevapA_TEXT;
    public TextMeshProUGUI CevapB_TEXT;
    public TextMeshProUGUI CevapC_TEXT;
    public TextMeshProUGUI CevapD_TEXT;
    string dogruCevap = "";


    public List<string[]> sorular = new List<string[]>
    {
        new string[] { "Türkiyenin baþkenti neresidir?", "istanbul", "ankara", "bursa", "sivas", "ankara" },
        new string[] { "En büyük okyanus hangisidir?", "atlas", "hint", "pasifik", "arktik", "pasifik" },
        new string[] { "Ay'ýn etrafýnda döndüðü gezegen nedir?", "mars", "jüpiter", "dünya", "merkür", "dünya" },
        new string[] { "Türkiye'nin en uzun nehri hangisidir?", "kýzýlýrmak", "yeþilýrmak", "sakarya", "fýrat", "kýzýlýrmak" },
        new string[] { "Ýstanbul'u fetheden Osmanlý padiþahý kimdir?", "yavuz sultan selim", "kanuni sultan süleyman", "fatih sultan mehmet", "2. murat", "fatih sultan mehmet" },
        new string[] { "Türkiye'nin en yüksek daðý hangisidir?", "kaçkar", "erciyes", "aðrý daðý", "palandöken", "aðrý daðý" },
        new string[] { "Güneþ sisteminde en büyük gezegen hangisidir?", "mars", "satürn", "dünya", "jüpiter", "jüpiter" },
        new string[] { "Türkiye'nin para birimi nedir?", "dolar", "euro", "lira", "sterlin", "lira" },
        new string[] { "Hangi hayvan uçamaz?", "martý", "serçe", "penguen", "atmaca", "penguen" },
        new string[] { "Ýzmir hangi bölgede yer alýr?", "karadeniz", "marmara", "ege", "akdeniz", "ege" },
        new string[] { "Cumhuriyet ne zaman ilan edilmiþtir?", "1920", "1923", "1938", "1919", "1923" }
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (soruSayisi < 10) soruOlustur(); renkleriSifirla();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (CevapA_TEXT.text == dogruCevap)
            {
                CevapA_TEXT.color = Color.green;
                Invoke("soruOlustur", 5f); Invoke("renkleriSifirla", 5f);
            }
            else CevapA_TEXT.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (CevapB_TEXT.text == dogruCevap)
            {
                CevapB_TEXT.color = Color.green;
                Invoke("soruOlustur", 5f); Invoke("renkleriSifirla", 5f);
            }
            else CevapB_TEXT.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (CevapC_TEXT.text == dogruCevap)
            {
                CevapC_TEXT.color = Color.green;
                Invoke("soruOlustur", 5f); Invoke("renkleriSifirla", 5f);
            }
            else CevapC_TEXT.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (CevapD_TEXT.text == dogruCevap)
            {
                CevapD_TEXT.color = Color.green;
                Invoke("soruOlustur", 5f); Invoke("renkleriSifirla", 5f);
            }
            else CevapD_TEXT.color = Color.red;
        }

    }

    void soruOlustur()
    {
        string[] soru = sorular[soruSayisi];
        Soru_TEXT.text = soru[0];
        CevapA_TEXT.text = soru[1];
        CevapB_TEXT.text = soru[2];
        CevapC_TEXT.text = soru[3];
        CevapD_TEXT.text = soru[4];
        dogruCevap = soru[5];
        if (soruSayisi < 10) soruSayisi++;
    }

    void renkleriSifirla()
    {
        CevapA_TEXT.color = Color.white;
        CevapB_TEXT.color = Color.white;
        CevapC_TEXT.color = Color.white;
        CevapD_TEXT.color = Color.white;
    }
}
