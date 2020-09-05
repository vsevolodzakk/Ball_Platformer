using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float jumpForce;
    public float maxSpeed;
    public GameObject cam;
    public bool onGround;
    public bool pJump;

    private AudioSource audioP;
    Vector3 headingVertical;
    Vector3 headingHorizontal;
    Vector3 headingJump;
    Collider playerCollider;

    void Start()
    {
        playerCollider = GetComponent<Collider>();
        pJump = false;
        audioP = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !pJump && onGround)
        {
            headingJump = Vector3.up * jumpForce * Time.deltaTime;
            pJump = true;
            audioP.Play();
        }
    }

    void FixedUpdate()
    {

        if (Input.GetAxisRaw("Vertical") == 1 && rb.velocity.z < maxSpeed)
            rb.AddForce(cam.transform.forward * force * Time.fixedDeltaTime);
        if (Input.GetAxisRaw("Vertical") == -1 && rb.velocity.z > -maxSpeed)
            rb.AddForce(cam.transform.forward * -force * Time.fixedDeltaTime);
        if (Input.GetAxisRaw("Horizontal") == -1 && rb.velocity.x > -maxSpeed)
            rb.AddForce(cam.transform.right * -force * Time.fixedDeltaTime);
        if (Input.GetAxisRaw("Horizontal") == 1 && rb.velocity.x < maxSpeed)
            rb.AddForce(cam.transform.right * force * Time.fixedDeltaTime);
        if (pJump && onGround == true)
        {
            rb.AddForce(Vector3.up * jumpForce * Time.deltaTime);
            onGround = false;
            pJump = false;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Platform")
            onGround = true;
        if (collision.gameObject.tag == "Platform")
        {
            transform.parent = collision.transform;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            transform.parent = null;
        }
    }

}
