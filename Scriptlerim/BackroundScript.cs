using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackroundScript : MonoBehaviour
{
    [Range(-1f,1f)]
    public float speedd = 0.5f;
    private float offset;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
     
    void Update()
    {
        offset += (Time.deltaTime * speedd) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
