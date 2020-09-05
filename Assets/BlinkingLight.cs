using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLight : MonoBehaviour
{
    //private System.Random coordX = new System.Random();
    //private System.Random coordZ = new System.Random();
    private float posX, posY, posZ, deltaX, deltaZ;
    Vector3 lightPosition;
    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        deltaX = UnityEngine.Random.Range(-0.1f, 0.1f);
        deltaZ = UnityEngine.Random.Range(-0.1f, 0.1f);
        lightPosition = new Vector3(posX + deltaX, posY, posZ + deltaZ);

        transform.position = lightPosition;
    }
}
