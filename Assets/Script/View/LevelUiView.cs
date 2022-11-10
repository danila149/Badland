using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelUiView : MonoBehaviour
{
    [SerializeField] private TMP_Text _levelText;
    
    void Start()
    {
        _levelText.text = "Level: " + PlayerPrefs.GetInt("level", 1);
    }
}
