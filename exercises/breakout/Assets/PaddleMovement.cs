using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour


{
    public KeyCode leftKey;
    public KeyCode rightKey;
    public float paddleSpeed = 0.1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(leftKey) && transform.position.x > -8f)
            {
                transform.position = new Vector3(transform.position.x - paddleSpeed, transform.position.y, 0);
            }

            if (Input.GetKey(rightKey) && transform.position.x < 8f)
            {
                transform.position = new Vector3(transform.position.x + paddleSpeed, transform.position.y, 0);
            }
        }
    }
}
