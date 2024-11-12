using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //Private Properties
    private Vector3 _mousePosition;
    private Vector3 _worldPosition; //??

    // Methods
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mousePosition = Input.mousePosition;

            //No entienbdo el código
            _mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
            _worldPosition = Camera.main.ScreenToWorldPoint(_mousePosition);
            transform.position = _worldPosition;
        }
    }
}


