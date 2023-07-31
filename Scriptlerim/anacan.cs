using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacan : MonoBehaviour
{
    public int objecani = 100;

   public void Takedamage(int canazaltma)
    {
        objecani -= canazaltma;
        if (objecani <= 0)
        {
            Die();

        }

    }


  

    void Die()
    {
        Destroy(gameObject);
    }
}
