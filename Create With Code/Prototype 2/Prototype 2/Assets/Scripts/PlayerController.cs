using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float horizontalInput;
    public float xRange = 10;
    
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        // Keep player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); 
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); 
        }
        
        // Player movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
