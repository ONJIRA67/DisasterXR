using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public float shakeMagnitude = 0.1f;
    public float shakeDuration = 60f;

    private float shakeTimer = 0f;
    private void Start()
    {
        shakeTimer = shakeDuration;
    }
    void Update()
    {
        if (shakeTimer > 0)
        {
            // Generate a random force vector
            Vector3 force = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f)) * shakeMagnitude;

            // Apply the force to the camera and objects
            transform.position += force;
            // repeat the force application for all objects you want to shake

            // Decrement the shake timer
            shakeTimer -= Time.deltaTime;
        }
    }

}
