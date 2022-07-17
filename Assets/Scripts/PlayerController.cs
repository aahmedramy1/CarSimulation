using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput, verticalInput;
    private readonly float turnSpeed = 45.0f, speed = 15.0f;
    public string inputID;
    public Camera mainCamera, hoodCamera;
    public KeyCode switchKey;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        // Move the vehicle forward
        transform.Translate(speed * Time.deltaTime * verticalInput * Vector3.forward);

        // Rotate the vehicle left and right
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);

        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
