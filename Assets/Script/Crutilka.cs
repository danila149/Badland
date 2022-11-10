using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crutilka : MonoBehaviour
{
    [SerializeField] private int rotationSpeed;
    private void Update()
    {
        transform.Rotate(0, 0, rotationSpeed / 100, Space.Self);
    }
}
