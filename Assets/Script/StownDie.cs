using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StownDie : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<StownView>() && collision.gameObject.GetComponent<GroundView>())
        {
            Debug.Log("Die2");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
