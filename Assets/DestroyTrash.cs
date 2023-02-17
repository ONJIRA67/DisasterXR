using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    public GameObject other;
    // Start is called before the first frame update
    public void OnDestroy()
    {
        Destroy(other);
    }
}
