using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public bool oyunAktif = true;
    public int altinSayisi = 0;
    public Text coinText;
    public Button baslaButon;
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }
    
    public void CoinArtir()
    {
        altinSayisi++;
        coinText.text = "" + altinSayisi;
    }

   public void OyunaBasla()
    {
        oyunAktif = true;
        baslaButon.gameObject.SetActive(false);
    }
}
