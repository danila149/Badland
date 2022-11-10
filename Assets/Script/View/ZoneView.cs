using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneView : MonoBehaviour
{
    [SerializeField] private Transform _bonus;
    [SerializeField] private float _incertime;
    private float _time;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<PlaerView>() && _bonus != null)
        {
            PlaerView plaer = collision.GetComponent<PlaerView>();
                
            _bonus.position = Vector3.Lerp(_bonus.position, plaer.transform.position, _time);
            _time += 0.001f;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlaerView>() && _bonus != null)
        {
            _time = 0;
        }
    }
}
