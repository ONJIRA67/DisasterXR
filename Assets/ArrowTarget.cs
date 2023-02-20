using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTarget : MonoBehaviour
{
    public Transform targetObject;
    public float arrowOffset = 0.5f;

    void Update()
    {
        Vector3 targetPos = targetObject.position * arrowOffset;
        transform.right = targetPos - transform.position;
    }
}
