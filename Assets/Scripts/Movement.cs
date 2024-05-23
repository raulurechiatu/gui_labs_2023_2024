using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        // Vector3 vect = new Vector3(x, y, z);
        // transform.position += new Vector3(horizontalAxis, 0, verticalAxis);
        rb.AddForce(new Vector3(horizontalAxis, 0, verticalAxis) * speed);
        // transform.position = new Vector3(transform.position.x + horizontalAxis, transform.position.y, transform.position.z + verticalAxis);
    }
}
