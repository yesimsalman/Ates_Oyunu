using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CnvrKrsnHrkt : MonoBehaviour
{
    public float hiz = 20f;
    public int canazaltma = 50;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = Vector2.up *hiz;
    }
    private void OnTriggerEnter2D(Collider2D temas)
    {
        can enemy = temas.GetComponent<can>();
        if (enemy != null)
        {
            enemy.TakeDamage(canazaltma);
        }
        Destroy(gameObject);
    }
}
