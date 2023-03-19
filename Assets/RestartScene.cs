using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    public void RestartObject()
    {
        transform.position = initialPosition;
    }
}
