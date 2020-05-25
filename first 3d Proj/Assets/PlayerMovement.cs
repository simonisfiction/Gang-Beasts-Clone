using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    public Rigidbody rb;

    public float lateralSpeed = .3f;
    public float forwardSpeed = .3f;
    public float upwardSpeed = .2f;

    int countForward = 0;
    int countBackward = 0;
    int countLeft = 0;
    int countRight = 0;
    public Vector3 inputVector;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.maxAngularVelocity = 1.0f;
     
    }

 

    //&& rb.GetRelativePointVelocity(0,0,0)[0] > 10

    // Update is called once per framea
    void FixedUpdate ()
    {
        //tf.Rotate(270, 90, 0);
        inputVector = new Vector3(Input.GetAxis("Horizontal") * 20f, rb.velocity.y, Input.GetAxis("Vertical") * 20f);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
        rb.velocity = inputVector;







        // rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        /*        
                if (Input.GetKey("a"))
                {
                    rb.AddForce(-lateralSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }

                if (Input.GetKey("d"))
                {
                    rb.AddForce(lateralSpeed * Time.deltaTime, 0, 0,  ForceMode.VelocityChange);
                }

                if (Input.GetKey("w"))
                {
                    rb.AddForce(0, 0, forwardSpeed * Time.deltaTime, ForceMode.VelocityChange);
                }

                if (Input.GetKey("s"))
                {
                    rb.AddForce(0, 0, -forwardSpeed * Time.deltaTime, ForceMode.VelocityChange);
                }
                 */
        if (Input.GetKey("space"))
        {
          rb.AddForce(0, upwardSpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
       
    }
}
