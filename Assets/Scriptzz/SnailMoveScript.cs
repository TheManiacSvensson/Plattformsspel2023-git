using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailMoveScript : MonoBehaviour
{
    public float SnailSpeed = 1f;
    Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
            RB.velocity = new Vector2(SnailSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Trigger")
        {
            RB.velocity *= -1;
        }
    }
}
