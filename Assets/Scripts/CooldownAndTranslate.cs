using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownAndTranslate : MonoBehaviour
{

    public float moveOffset;
    public float speed;
    public int counter;
    public int cooldown;

    public bool marker;

    private float objectPosition;
    private AudioSource sound;
    
    void Start()
    {
        objectPosition = transform.position.z;
        counter = 0;
        sound = GetComponent<AudioSource>();
        //marker = true;
        
    }

    
    void Update()
    {
        counter++;
        if (marker == true && counter > cooldown)
        {
            transform.Translate(transform.forward * -speed * Time.deltaTime);
            sound.Play();
            if (transform.position.z < (objectPosition - moveOffset))
            {
                marker = false;
                counter = 0;
            }
        }
        else if (marker == false && counter > cooldown)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
            sound.Play();
            if (transform.position.z > (objectPosition + moveOffset))
            {
                marker = true;
                counter = 0;
            }
        }


    }
}
