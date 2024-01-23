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

    [SerializeField] private TrailRenderer tr;


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

       if (Input.GetKey(KeyCode.LeftShift) && isOnGround)
        {
            myRigidbody.velocity = new Vector3(transform.forward.x * dashingPower, 0f, transform.forward.z * dashingPower);
        }

       
    }

}
