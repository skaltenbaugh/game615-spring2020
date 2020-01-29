using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleMovement : MonoBehaviour
{
    public float paddleSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && transform.position.y < 3.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + paddleSpeed, 0);
        }

        if (Input.GetKey(KeyCode.L) && transform.position.y > -3.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - paddleSpeed, 0);
        }
    }
}
