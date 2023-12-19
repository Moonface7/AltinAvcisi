using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public game oyunK;
    public AudioClip coin, fall;
    private float hiz = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        if(oyunK.oyunAktif)
        {
            //yön bilgileri 
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            //hareket hizi belirleme
            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("coin"))
        {
            oyunK.CoinArtir();
            GetComponent<AudioSource>().PlayOneShot(coin,1f);
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.tag.Equals("dusman"))
        {
            GetComponent<AudioSource>().PlayOneShot(fall, 1f);
            oyunK.oyunAktif = false;
        }
    }
}
