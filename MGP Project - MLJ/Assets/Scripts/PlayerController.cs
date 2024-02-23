using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float  maxSpeed = 0.0f;
    Rigidbody myRigidbody;
    public Animator myAnimator;
    GameObject cam;

    public Transform CharRotation;

    float camRotation = 1.5f;
    float rotationSpeed = 2.0f;
    float rotation = 0.0f;

    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;
    public float jumpForce = 50.0f;


    void Start()
    { 
        myRigidbody = GetComponent<Rigidbody>();
        cam = GameObject.Find("Main Camera");

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        camRotation = camRotation + Input.GetAxis("Mouse X") * rotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(56.918f, camRotation, 0.0f));

        CharRotation.localRotation = Quaternion.Euler(new Vector3(0.0f, camRotation, 0.0f));


        /*transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical"));*/
        
        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        //camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotation

        /*Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed;
        myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);*/

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
