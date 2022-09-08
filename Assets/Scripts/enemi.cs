using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hal;
    gamecontroLler1 hihi;
    dichuyen ahu;
    public float moveSpeed;
    float time;
    public Rigidbody2D enemidichuyen;
    Transform huhu;
    audiosource hit;
    void Start()
    {
        hihi = FindObjectOfType<gamecontroLler1>();
        ahu = FindObjectOfType<dichuyen>();
        huhu = GetComponent<Transform>();
        enemidichuyen = GetComponent<Rigidbody2D>();
        hit = FindObjectOfType<audiosource>();
    }
    
    private void OnCollisionEnter2D(Collision2D col)   
    {
        if (col.gameObject.CompareTag("gun"))
        {
            if (hit.audio != null)
            {
                hit._die();
            }         
            hihi._setisShowpanel(true);
            Debug.Log("da va cham, game over");
        }
        if ((col.gameObject.CompareTag("background"))|| (col.gameObject.CompareTag("enemi")))
        {
            enemidichuyen.velocity = Vector2.left * moveSpeed;
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);         
        }      
    }
   
}
