using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPostToAp : MonoBehaviour
{
    public static Vector3 positionPost;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        positionPost = rb.transform.position;

        rb.transform.position = TeleportApToPost.positionAp;
    }


    void Update()
    {
        positionPost = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
 