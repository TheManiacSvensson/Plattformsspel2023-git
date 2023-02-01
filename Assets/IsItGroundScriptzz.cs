using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsItGroundScriptzz : MonoBehaviour
{

    public bool IsOnGround = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        IsOnGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsOnGround = false;
    }
}
