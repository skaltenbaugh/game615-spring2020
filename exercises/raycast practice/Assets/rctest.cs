using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rctest : MonoBehaviour
{
    public Transform raycast;

    public Camera cam;

    float yaw = 0f;
    float pitch = 0f;
    float speedH = 5f;
    float speedV = 5f;

    float range = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;

        if (Input.GetMouseButtonDown(0))
        {
            Raycast();
        }
        
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
    void Raycast()
    {
        // Center Screen Raycasting

        RaycastHit hit;
        if (Physics.Raycast(raycast.transform.position,
            raycast.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

        }
    }

}
