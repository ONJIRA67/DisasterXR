using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject button;
    public bool triggerTable = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            button.SetActive(true);
            triggerTable = true;
        }
    }
}
