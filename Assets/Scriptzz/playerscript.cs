using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    Rigidbody2D rb;
    public float MoveSpeed = 10;
    public float JumpStrength = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-MoveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2 (0, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(MoveSpeed, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, JumpStrength));
        }

    }
}
