using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    public float speed = 15f;
    public float speedIncrease = 1.0f; 
    public float maxSpeed = 100f; 
    public float increaseInterval = 1.0f;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            // Gọi GameOver
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
