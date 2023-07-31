using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CnvrAtes : MonoBehaviour
{
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
