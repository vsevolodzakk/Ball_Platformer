using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChase : MonoBehaviour
{
    public Transform objectToFollow;
    private Vector3 deltaPosition;

    // Start is called before the first frame update
    void Start()
    {
        deltaPosition = transform.position - objectToFollow.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = objectToFollow.position + deltaPosition;
    }
}
