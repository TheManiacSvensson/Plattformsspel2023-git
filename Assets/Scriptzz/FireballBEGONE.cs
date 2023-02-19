using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBEGONE : MonoBehaviour
{

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if  (collision.collider.tag == "FireBall" || collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
