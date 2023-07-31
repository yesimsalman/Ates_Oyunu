using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kalpCan : MonoBehaviour
{ //public AudioClip patlama;
    public int kalpcani = 20;

    public void TakeDamage(int canazaltma)
    {
        kalpcani -= canazaltma;
        Die();
       /*....kalpcani -= canazaltma;

        if (kalpcani <= 0)
        {
            Die();
        }
        //  AudioSource.PlayClipAtPoint(patlama, transform.position);
       */
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
