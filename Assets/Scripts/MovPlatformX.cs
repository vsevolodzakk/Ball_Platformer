using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlatformX : MonoBehaviour
{
    public bool marker;
    public float moveOffset = 1f;
    public float speed;
    private float platformPosition;

    void Start()
    {
        platformPosition = transform.position.x;
        marker = true;
    }

    void Update()
    {
        if ((transform.position.x > (platformPosition - moveOffset)) && (marker == true))
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
            if (transform.position.x < (platformPosition - moveOffset)) marker = false;
        }
        else if ((transform.position.x < (platformPosition + moveOffset)) && (marker == false))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
            if (transform.position.x > (platformPosition + moveOffset)) marker = true;
        }
    }
}
