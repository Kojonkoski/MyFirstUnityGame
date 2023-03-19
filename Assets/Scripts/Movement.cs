using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public float originalSpeed;
    public float boostSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        originalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Jump"))
        {
            speed = boostSpeed;
        }

        else
        {
            speed = originalSpeed;
        }

        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;

        Rigidbody rb = GetComponent<Rigidbody>();
        /*
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right);

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left);
        */
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.up);

        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.down);
    }

    
}
