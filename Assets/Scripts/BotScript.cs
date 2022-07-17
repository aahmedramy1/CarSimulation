using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotScript : MonoBehaviour
{
    private readonly float botSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(botSpeed * Time.deltaTime * Vector3.forward);
    }
}
