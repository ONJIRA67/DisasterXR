using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objectsToRestart;

    private Dictionary<GameObject, Vector3> initialPositions = new Dictionary<GameObject, Vector3>();

    void Start()
    {
        foreach (GameObject obj in objectsToRestart)
        {
            initialPositions[obj] = obj.transform.position;
        }
    }

    public void RestartObjects()
    {
        foreach (GameObject obj in objectsToRestart)
        {
            obj.transform.position = initialPositions[obj];
        }
    }
}
