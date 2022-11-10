using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerView : MonoBehaviour
{
    [SerializeField] private Transform _plaerTransform;

    void Update()
    {
        transform.position = new Vector3(_plaerTransform.position.x, transform.position.y, -10);
    }
}
