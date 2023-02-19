using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    Rigidbody2D rb;
    public float MoveSpeed = 10;
    public float JumpStrength = 2;
    public float YeetSpeed = 20;
    public float FireBallDespawn = 2;
    public GameObject Fireball;
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

        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject NewFireBall = Instantiate(Fireball, transform.position, Quaternion.identity);
            Rigidbody2D FireBallRB2D = NewFireBall.GetComponent<Rigidbody2D>();
            FireBallRB2D.velocity = new Vector2(YeetSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject NewFireball = Instantiate(Fireball, transform.position, Quaternion.identity);
            Rigidbody2D FireBallRB2D = NewFireball.GetComponent<Rigidbody2D>();
            FireBallRB2D.velocity = new Vector2(-YeetSpeed, 0);
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
