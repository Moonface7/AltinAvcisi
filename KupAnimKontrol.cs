using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupAnimKontrol : MonoBehaviour
{
    float sayac = 2f;
   
    void Start()
    {
        
    }
   
    void Update()
    {
        sayac = Time.deltaTime;
        if(sayac < 0 )
        {
            GetComponent<Animator>().Play(0); // animator uzerinde 0.degerdeki animi oynatmak 
            sayac = Random.Range(4, 6);  // random surelerde 
        }
    }
}
