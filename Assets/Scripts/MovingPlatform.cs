using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public bool marker;
    
    private float platformPosition;
    public float moveOffset = 1f;
    public float speed;

    void Start()
    {
        platformPosition = transform.position.z;
        marker = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.z > (platformPosition - moveOffset)) && (marker == true))
        {
            transform.Translate(transform.forward * -speed * Time.deltaTime);
            if (transform.position.z < (platformPosition - moveOffset)) marker = false;
        }    
        else if ((transform.position.z < (platformPosition + moveOffset)) && (marker == false))
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
            if (transform.position.z > (platformPosition + moveOffset)) marker = true;
        }
    }
}
