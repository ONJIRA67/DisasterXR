using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour
{
    // Start is called before the first frame update
    public float duration = 10f;
    public float force = 1f;

    private float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (Time.time - startTime < duration)
        {
            // Apply a random force to all objects in the scene
            foreach (Rigidbody rb in FindObjectsOfType<Rigidbody>())
            {
                rb.AddForce(Random.insideUnitSphere * force, ForceMode.Impulse);
            }
        }
    }
}
