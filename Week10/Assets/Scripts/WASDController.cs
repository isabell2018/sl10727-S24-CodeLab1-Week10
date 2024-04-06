using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public int velocity = 5;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up*velocity);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down*velocity);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left*velocity);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right*velocity);
        }
    }
}
