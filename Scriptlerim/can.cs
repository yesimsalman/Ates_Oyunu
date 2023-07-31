using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class can : MonoBehaviour
{
    //public AudioClip patlama;
    public int objecani = 100;
    
    public void TakeDamage(int canazaltma)
    {
       objecani -= canazaltma;

        if (objecani <= 0)
        {           
            Die();            
        }
      //  AudioSource.PlayClipAtPoint(patlama, transform.position);

    }

    void Die()
    {
        Destroy(gameObject);        
    }
}
