using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketDestroy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BoxTrash")
        {
            Destroy(other.gameObject);
        }
    }
}
