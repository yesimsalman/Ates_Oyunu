using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kursunhareket : MonoBehaviour
{
   public AudioClip patlama;
    public float hiz = 20f;
    public int canazaltma=50;
    public Rigidbody2D rb;

    //int puan = 0;
    //public Text puanGoster;

    void Start()
    {
        rb.velocity =Vector2.down * hiz;
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        can ennemy = temas.GetComponent<can>();
        if(ennemy != null)
        {
            ennemy.TakeDamage(canazaltma);
            
        }
        Destroy(gameObject);

           /*while (temas.gameObject.tag == "enemy")
            {
                puan = puan + 10;
                Debug.Log(puan);
            if (puan == 100)
            {
                break;
                Debug.Log("Kazandýnýz..");
            }
            }*/

        
        AudioSource.PlayClipAtPoint(patlama, transform.position,2f);

    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Kalp")
        {
            puan++;
            puanGoster.text = "Skor: " + puan;
        }
    }*/

}
