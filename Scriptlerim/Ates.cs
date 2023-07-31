using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{
    public AudioSource audios;
    public Transform atesnoktasi;
    public GameObject kursun;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AtesEtme();
            
        }
    }

    void AtesEtme()
    {
       Instantiate(kursun, atesnoktasi.position, atesnoktasi.rotation);
       
    }
}
