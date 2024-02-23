using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float  maxSpeed = 1.0f;
    Rigidbody myRigidbody;
    public Animator myAnimator;

    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;
    public float jumpForce = 50.0f;


    void Start()
    { 
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        myRigidbody.velocity = new Vector3(horizontalInput * maxSpeed, myRigidbody.velocity.y, verticalInput * maxSpeed);

        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        myAnimator.SetBool("isOnGround", isOnGround);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetTrigger("jumped");
            myRigidbody.AddForce(transform.up * jumpForce);
        }
    }
}
