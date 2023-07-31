using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KalpSpawn : MonoBehaviour
{
    public GameObject[] prefabDusmanlar;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDusman", 4, 5f);
    }
    void SpawnDusman()
    {
        int dusmanIndis = Random.Range(0, prefabDusmanlar.Length);
        float konumX = Random.Range(-19.5f, 20.7f);
        Instantiate(prefabDusmanlar[dusmanIndis], new Vector3(konumX, -1, -1), prefabDusmanlar[dusmanIndis].transform.rotation);
    }
}
