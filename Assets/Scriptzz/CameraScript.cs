using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    GameObject target;
    Camera cam;

    public float HorizontalPadding = 3.0f;
    public float VerticalPadding = 2.0f;

    float maxHorizontalDistance;
    float maxVerticalDistance;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        cam = GetComponent<Camera>();

        maxVerticalDistance = cam.orthographicSize - VerticalPadding;
        maxHorizontalDistance = cam.orthographicSize * cam.aspect - HorizontalPadding;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.transform.position.x > transform.position.x + maxHorizontalDistance)
        {
            SetX(target.transform.position.x - maxHorizontalDistance);
        }
        if (target.transform.position.x < transform.position.x - maxHorizontalDistance)
        {
            SetX(target.transform.position.x + maxHorizontalDistance);
        }
        if (target.transform.position.y > transform.position.y + maxVerticalDistance)
        {
            SetY(target.transform.position.y - maxVerticalDistance);
        }
        if (target.transform.position.y < transform.position.y - maxVerticalDistance)
        {
            SetY(target.transform.position.y + maxVerticalDistance);
        }
    }

    void SetX(float NewX)
    {
        transform.position = new Vector3(NewX, transform.position.y, transform.position.z);
    }
    void SetY(float NewY)
    {
        transform.position = new Vector3(transform.position.x, NewY, transform.position.z);

    }
}
