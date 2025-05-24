using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy_Controller : MonoBehaviour
{
    protected float Speed; 
    // Start is called before the first frame update
    protected virtual void Start()
    {
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Speed += Time.deltaTime * 0.8f;
        transform.Translate(Vector3.back * Speed * Time.deltaTime);
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().GameOver();
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            FindObjectOfType<ScoreManager>().AddScore(1);
        }
    }
}
