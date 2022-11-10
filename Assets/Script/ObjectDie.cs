using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDie : MonoBehaviour
{
    [SerializeField] private int rotationSpeed;
    private void Update()
    {
        transform.Rotate(0, 0, rotationSpeed / 100, Space.Self);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlaerView>())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
