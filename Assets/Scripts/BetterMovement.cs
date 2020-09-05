using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterMovement : MonoBehaviour
{
    public float stopingMultiplier = 2f;
    public GameObject cam;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("RB Velocity Z:" + rb.velocity.z);
        Debug.Log("RB Velocity X:" + rb.velocity.x);
        //if (Input.GetAxisRaw("Vertical") == 0 && rb.velocity.z > 0)
        //{
        //    rb.velocity -= Vector3.forward * (stopingMultiplier - 1) * Time.deltaTime;
        //} else if (Input.GetAxisRaw("Vertical") == 0 && rb.velocity.z < 0)
        //{
        //    rb.velocity += Vector3.forward * (stopingMultiplier - 1) * Time.deltaTime;
        //}
        //if (Input.GetAxisRaw("Horizontal") == 0 && rb.velocity.x > 0)
        //{
        //    rb.velocity -= Vector3.right * (stopingMultiplier - 1) * Time.deltaTime;
        //} else if (Input.GetAxisRaw("Horizontal") == 0 && rb.velocity.x < 0)
        //{
        //    rb.velocity += Vector3.right * (stopingMultiplier - 1) * Time.deltaTime;
        //}

        if (Input.GetAxisRaw("Vertical") == 0 && rb.velocity.z > 0)
        {
            rb.AddForce(cam.transform.forward * -stopingMultiplier * Time.fixedDeltaTime);
        }
        else if (Input.GetAxisRaw("Vertical") == 0 && rb.velocity.z < 0)
        {
            rb.AddForce(cam.transform.forward * stopingMultiplier * Time.fixedDeltaTime);
        }
        if (Input.GetAxisRaw("Horizontal") == 0 && rb.velocity.x > 0)
        {
            rb.AddForce(cam.transform.right * -stopingMultiplier * Time.fixedDeltaTime);
        }
        else if (Input.GetAxisRaw("Horizontal") == 0 && rb.velocity.x < 0)
        {
            rb.AddForce(cam.transform.right * stopingMultiplier * Time.fixedDeltaTime);
        }

    }
}
