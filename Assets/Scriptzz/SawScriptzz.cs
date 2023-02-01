using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawScriptzz : MonoBehaviour
{

    Rigidbody2D rb2D;
    public Vector2 StartVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = StartVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Trigger")
        {
            rb2D.velocity *= -1;
        }
    }
}
