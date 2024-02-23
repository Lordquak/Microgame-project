using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportApToPost : MonoBehaviour
{
    public static Vector3 positionAp;
    Rigidbody rb;
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        positionAp = rb.transform.position;

        rb.transform.position = TeleportPostToAp.positionPost;
    }


    void Update()
    {
        positionAp = new Vector3(transform.position.x, transform.position.y, transform.position.z);

    }
}
