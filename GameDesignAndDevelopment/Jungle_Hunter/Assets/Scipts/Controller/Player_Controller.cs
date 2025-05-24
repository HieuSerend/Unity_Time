using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        // Move the player based on the input
        Vector3 movement = new Vector3(horizontalInput, 0, 0) * speed * Time.deltaTime;
        player.transform.Translate(movement);

        if (transform.position.x < -24.0f)
        {
            transform.position = new Vector3(-24.0f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 20.0f)
        {
            transform.position = new Vector3(20.0f, transform.position.y, transform.position.z);
        }
    }
}
