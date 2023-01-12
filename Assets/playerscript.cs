using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    Rigidbody2D rb;
    public float MoveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(MoveSpeed,0);
        }
        else
        {
            rb.velocity = new Vector2 (0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-MoveSpeed, 0);
        }
    }
}
