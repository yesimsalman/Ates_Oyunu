using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanTemas : MonoBehaviour
{
    
    public Transform carpma;
    public GameObject guleryuz;

    void Update()
    {
        
    }

    void AtesEtme()
    {
        Instantiate(guleryuz, carpma.position, carpma.rotation);

    }
}
