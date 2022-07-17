using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new(0f, 5f, -7f);

    // Update is called once per frame
    private void LateUpdate()
    {
        // offset the camera's position to be behind the vehicle
        transform.position = player.transform.position + offset;
    }
}
