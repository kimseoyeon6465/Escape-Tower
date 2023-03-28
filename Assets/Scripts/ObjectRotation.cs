using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    private float _startingAngle;
    private Vector3 _startingMousePosition;

    void OnMouseDown()
    {
        _startingAngle = transform.eulerAngles.z;
        _startingMousePosition = Input.mousePosition;
        Debug.Log("OnMouseDown");
    }

    void OnMouseDrag()
    {
        float currentMousePosition = Input.mousePosition.x;
        float mouseOffset = currentMousePosition - _startingMousePosition.x;

        float rotationAmount = mouseOffset / Screen.width * 360.0f;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, _startingAngle - rotationAmount);
        Debug.Log("OnMouseDrag");

    }
}
