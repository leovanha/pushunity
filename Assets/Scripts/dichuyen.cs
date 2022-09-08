using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    public float moveSpeed;
    public float boundfounrce;
    public GameObject vienDan;
    public Transform hehe;
    gamecontroLler1 hihi;
    public float jump;
    public static dichuyen dichuyen1;
    audiosource hit;
    public GameObject go;

    void Start()
    {
        Time.timeScale = 0;
        hihi = FindObjectOfType<gamecontroLler1>();
        hit = FindObjectOfType<audiosource>();
    }

    void Update()
    {
       
       float dichuyen =  Input.GetAxisRaw("Horizontal");
        float jump = Input.GetAxisRaw("Vertical");
        if ((dichuyen > 0 && transform.position.x > 8f) || (dichuyen < 0 && transform.position.x < -8f))
        {
            return;          
        }
        transform.position = transform.position + Vector3.right * moveSpeed * dichuyen * Time.deltaTime;
        transform.position = transform.position + Vector3.up * jump * boundfounrce * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _viendan();
        }
    }
    public void _viendan()
    {
        if (vienDan && hehe != null)
        {
            Instantiate(vienDan, hehe.position, Quaternion.identity);
            if (hit.audio != null)
            {
                hit._bandan();
            }
            
            
        }
    }
   public void _Go()
    {
        Time.timeScale = 1;
        go.SetActive(false);
    }
    
}
