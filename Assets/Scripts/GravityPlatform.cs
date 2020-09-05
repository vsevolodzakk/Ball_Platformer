using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPlatform : MonoBehaviour
{
    public Vector3 startPosition;
    public float dropForce;

    private void Start()
    {
        startPosition = transform.position;
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.Translate(transform.up * -dropForce * Time.fixedDeltaTime);
            
        }
    }
    //public void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        transform.Translate(startPosition);
    //    }
    //}
}
