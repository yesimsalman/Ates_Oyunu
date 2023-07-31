using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puan : MonoBehaviour
{
    public int toppuan = 0;
   



    private void OnCollisionEnter(Collision coll)
    {
        
        if (coll.gameObject.tag == "enemy")
        {
            toppuan += 10;
            Debug.Log(toppuan);
        }
    }
    

}
