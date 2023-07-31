using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlamasesi : MonoBehaviour
{
    public AudioClip patlama;
    public int toppuan = 10;
    void Start()
    {
       // ses = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.PlayClipAtPoint(patlama, transform.position);
        
    }

    /* private void OnCollisionEnter(Collision col)
     {
         if (col.gameObject.tag == "enemy")
         {
             ses.Play();
             Debug.Log("Çarptý");
             Destroy(col.gameObject);
         }
     }*/
    private void OnCollisionEnter(Collision col)
    {
        toppuan += 10;
        Debug.Log(toppuan);
        Destroy(col.gameObject);
    }
}
