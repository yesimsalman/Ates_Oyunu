using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterhareket : MonoBehaviour
{
    public Rigidbody2D fizik;
    public int hiz;
    Vector2 hareket;
    void Start()
    {
        
    }

    
    void Update()
    {
        hareket.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        fizik.MovePosition(fizik.position+ hareket* hiz* Time.fixedDeltaTime);
    }
}
