using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float  maxSpeed = 1.0f;
    Rigidbody myRigidbody;

    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;
    [SerializeField] float jumpForce = 300f;

    public float dashingPower = 20f;
    private bool dash;

    public Vector2 bdash;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
         float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        myRigidbody.velocity = new Vector3 (horizontalInput * maxSpeed, myRigidbody.velocity.y, verticalInput * maxSpeed);
        
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(transform.up * jumpForce);
        }

       if (Input.GetKey(KeyCode.LeftShift) && isOnGround && !dash)
        {
            bdash.x = horizontalInput;
            bdash.y = verticalInput;

            myRigidbody.velocity = new Vector3(bdash.x * dashingPower, 0f, bdash.y * dashingPower);

            dash = true;
        }
        else if (Input.GetKey(KeyCode.LeftShift) && dash)
        {
            myRigidbody.velocity = new Vector3(bdash.x * dashingPower, 0f, bdash.y * dashingPower);
        }
       else if (!Input.GetKey(KeyCode.LeftShift) && dash)
        {
            dash = false;
        }

       
    }

}
