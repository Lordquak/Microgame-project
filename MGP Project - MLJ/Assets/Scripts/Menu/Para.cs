using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Para : MonoBehaviour
{
    public float speed = 10.0f;
    private void Start()
    {

    }
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, speed, 0);
        transform.Translate((direction * (speed * Time.deltaTime)));
    }
}




