using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duvar : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.tag =="enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
