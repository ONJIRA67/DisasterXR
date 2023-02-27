using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPhotofame : MonoBehaviour
{
    // Start is called before the first frame update
    public bool triggerPhotofame = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerPhotofame = true;
        }
    }
}
