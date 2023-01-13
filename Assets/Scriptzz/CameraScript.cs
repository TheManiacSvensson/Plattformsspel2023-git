using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag()
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -15);
    }
}