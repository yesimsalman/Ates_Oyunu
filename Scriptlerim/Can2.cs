using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can2 : MonoBehaviour
{
    public int objecani = 100;

    public void TakeDamage(int canazaltma)
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
