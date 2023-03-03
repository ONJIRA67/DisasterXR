using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour
{
    // Start is called before the first frame update
    public float duration = 60f;
    public float shakeMagnitude = 0.1f;
    public GameObject exist;
    public GameObject inTable; 

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
                Vector3 force = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * shakeMagnitude;

                rb.AddForce(force, ForceMode.Impulse);
            }
        }
        if (Time.time - startTime >= duration)
        {
            inTable.SetActive(false);
            exist.SetActive(true);
        }
            

    }
}
