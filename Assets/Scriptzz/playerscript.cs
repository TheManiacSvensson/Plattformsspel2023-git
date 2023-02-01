using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    Rigidbody2D rb;
    public float MoveSpeed = 10;
    public float JumpStrength = 290;

    IsItGroundScriptzz Groundscript;
    Vector3 StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartPosition = transform.position;
        Groundscript = GetComponentInChildren<IsItGroundScriptzz>();
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
        if (Input.GetKeyDown(KeyCode.Space) && Groundscript.IsOnGround == true)
        {
            //rb.AddForce(new Vector2(0, JumpStrength));
            rb.velocity = new Vector2(rb.velocity.x, JumpStrength);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            transform.position = StartPosition;
        }
    }
}
