using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal"); // "Horizontal" is the default Unity input for the arrow keys and A/D keys
        forwardInput = Input.GetAxis("Vertical"); // "Vertical" is the default Unity input for the arrow keys and W/S keys
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // forward is positive, back is negative
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); // down is negative, up is positive
    }
}
