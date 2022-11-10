using UnityEngine;
using UnityEngine.SceneManagement;

public class RextarterUI : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetInt("level",1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
