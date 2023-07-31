using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManage2 : MonoBehaviour
{
    public GameObject[] prefabDusmanlar;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDusman", 6, 2f);
    }
    void SpawnDusman()
    {
        int dusmanIndis = Random.Range(0, prefabDusmanlar.Length);
        float konumX = Random.Range(-19.5f, 20.7f);
        Instantiate(prefabDusmanlar[dusmanIndis], new Vector3(konumX, -3, -1), prefabDusmanlar[dusmanIndis].transform.rotation);
    }

}
