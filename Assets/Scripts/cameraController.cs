using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float speed = 1;

    private float pitch; 
    private float yaw;
    void Start()
    {
        
    }
    
    void Update()
    {
        GameObject playerCamera = transform.GetChild(0).gameObject;

        if (Input.GetMouseButton(1)) {
            pitch += speed * -Input.GetAxis("Mouse Y");
            yaw += speed * Input.GetAxis("Mouse X");

            pitch = Mathf.Clamp(pitch, -90f, 90f);

            while (yaw < 0f) {
                yaw += 360f;
            }

            while (yaw >= 360f) {
                yaw -= 360f;
            }

            //looked this one up. needed to set rotation as float values
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yaw, transform.rotation.eulerAngles.z);
            playerCamera.transform.rotation = Quaternion.Euler(pitch, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
    }
}
