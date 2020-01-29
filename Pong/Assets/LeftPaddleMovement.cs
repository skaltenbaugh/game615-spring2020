using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMovement : MonoBehaviour
{

    public float paddleSpeed = 0.1f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < 3.5f) { 
            transform.position = new Vector3(transform.position.x,transform.position.y + paddleSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > -3.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - paddleSpeed, 0);
        }
    }
}
// Task 1. Implement behaviour for LeftPaddle to go down when key S is pressed
// Task 2. Implement behaviour for Right Paddle when P and L is pressed
//         (we will do arrows later, together)