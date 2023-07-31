using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odul : MonoBehaviour
{
    public AudioClip success;
    public int puan = 0;
    public float hiz = 20f;
    public int canazaltma = 20;
  //  public Rigidbody2D rb;

    void Start()
    {
       // rb.velocity = Vector2.down * hiz;
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        kalpCan kalp = temas.GetComponent<kalpCan>();
        if (kalp != null)
        {
            kalp.TakeDamage(canazaltma);

        }
        Destroy(gameObject);
        

        AudioSource.PlayClipAtPoint(success, transform.position, 2f);

    }
}
