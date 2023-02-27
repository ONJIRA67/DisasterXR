using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxHallway : MonoBehaviour
{
    // Start is called before the first frame update
    public bool triggerBoxHallway = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerBoxHallway = true;
        }
    }
}
