using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public game oyunK;
    float sens = 2f;
    float yumusaklik = 2f;
    Vector2 gecisPos;
    Vector2 camPos;
    GameObject oyuncu;

    void Start()
    {
        oyuncu = transform.parent.gameObject;
        camPos.y = 12f;
    }

    void Update()
    {
        if(oyunK.oyunAktif)
        {
            //yon bilgileri
            Vector2 mousePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            mousePos = Vector2.Scale(mousePos, new Vector2(sens * yumusaklik, yumusaklik * sens)); //gercege yakin hareket elde etme
            gecisPos.x = Mathf.Lerp(gecisPos.x, mousePos.x, 1 / yumusaklik); // mouse x degerleri arasinda belirtilen surede gecis
            gecisPos.y = Mathf.Lerp(gecisPos.y, mousePos.y, 1 / yumusaklik);
            camPos += gecisPos;
            transform.localRotation = Quaternion.AngleAxis(-camPos.y, Vector3.right); // kameranin ekseni etrafinda kamerayi yukari asagi donme
            oyuncu.transform.localRotation = Quaternion.AngleAxis(camPos.x, oyuncu.transform.up); // kamera ekseni etrafinda oyuncuyu saga sola dondurme
        }
    } 
}
