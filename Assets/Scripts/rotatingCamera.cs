using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingCamera : MonoBehaviour
{
    public float sensivity;
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float rotation = Input.GetAxis("Mouse X");
        transform.RotateAround(target.transform.position, Vector3.up, rotation * sensivity * Time.fixedDeltaTime);
        //transform.LookAt(target.transform);
    }
}
