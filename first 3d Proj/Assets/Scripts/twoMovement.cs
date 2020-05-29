using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoMovement : MonoBehaviour
{

    // Use this for initialization
    public Rigidbody rb;

    public float lateralSpeed = 20f;
    public float forwardSpeed = 20f;
    public float upwardSpeed = 20f;

 //   int countForward = 0;
 //   int countBackward = 0;
 //   int countLeft = 0;
 //   int countRight = 0;
    public Vector3 inputVector;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.maxAngularVelocity = 1.0f;
        Physics.gravity = new Vector3(0, -5f, 0);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("j"))
        {
            rb.AddForce(-lateralSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("l"))
        {
            rb.AddForce(lateralSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("i"))
        {
            rb.AddForce(0, 0, forwardSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("k"))
        {
            rb.AddForce(0, 0, -forwardSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}