using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPress : MonoBehaviour
{
    public float moveOffset;
    public float speed;
    public int counter;
    public int cooldown;

    public bool marker;

    private float objectPosition;
    AudioSource pressSound;

    // Start is called before the first frame update
    void Start()
    {
        pressSound = GetComponent<AudioSource>();
        objectPosition = transform.position.y;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (marker == true && counter > cooldown)
        {
            transform.Translate(transform.up * -speed * Time.deltaTime);
            
            if (transform.position.y < (objectPosition - moveOffset))
            {
                marker = false;
                counter = 0;
                pressSound.Play();
            }
        }
        else if (marker == false && counter > cooldown)
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
            
            if (transform.position.y > objectPosition)
            {
                marker = true;
                pressSound.Play();
                counter = 0;
            }
        }
    }
}
