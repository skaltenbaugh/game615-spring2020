using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    float forceX = 0;
    float forceY = 0;
    float magnitude = 500;

    void launchBall()
    {
        transform.position = new Vector3(0, 0, 0);
        float forceX = Random.Range(-0.5f, 0.5f);
        float forceY = Random.Range(-0.5f, 0.5f);
        Vector3 force = new Vector3(forceX, forceY, 0);

        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().AddForce(force * magnitude);
    }
      private void Start()
    {
        launchBall();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BottomWall")
        {
            transform.position = new Vector3(0, 0, 0);
            launchBall();
        }
        else if (collision.gameObject.tag == "brick")
        {
            forceX = forceX * -1;
            forceY = forceY * -1;
        }
        else if (collision.gameObject.name == "Paddle")
        {
            forceX = forceX * -1;
            forceY = forceY * -1;

        }
    }
    private void Update()
    {
        }
}

