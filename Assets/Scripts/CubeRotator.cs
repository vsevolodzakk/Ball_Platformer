using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public Rigidbody rb;
    private float rotationForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rotationForce = Random.Range(5f, 10f);
        rb.AddTorque(transform.up * rotationForce * Time.deltaTime);
        rb.AddTorque(transform.right * rotationForce * Time.deltaTime);
    }
}
