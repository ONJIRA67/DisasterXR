using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle toggle;

    private bool destroyed = false;

    void OnDestroy()
    {
        destroyed = true;
        toggle.isOn = true;
    }

    void Update()
    {
        if (!destroyed && toggle.isOn)
        {
            toggle.isOn = false;
        }
    }
}
