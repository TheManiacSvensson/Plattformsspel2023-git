using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
