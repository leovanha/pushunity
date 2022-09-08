using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viendan : MonoBehaviour
{
    public Rigidbody2D viendan1;
    public float moveSpeed;
    gamecontroLler1 hihi;
    audiosource hit;
    
    void Start()
    {
        hit = FindObjectOfType<audiosource>();
        hihi = FindObjectOfType<gamecontroLler1>();
    }
    void Update()
    {
              
            viendan1.velocity = Vector2.right * moveSpeed;
           
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("enemi"))
        {
            if (hit.audio)
            {
                hit._trungdan();
            }
            Destroy(gameObject);
            Destroy(col.gameObject);
            hihi._diemSo();
        }
        if (col.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
