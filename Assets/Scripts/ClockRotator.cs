using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotator : MonoBehaviour
{
    private Vector3 mouseStartPosition;
    private float rotateSpeed = 5f;

    void OnMouseDown()
    {
        mouseStartPosition = Input.mousePosition;
        Debug.Log("OnMouseDown");
    }

    void OnMouseDrag()
    {
        Vector3 currentMousePosition = Input.mousePosition;
        Vector3 difference = currentMousePosition - mouseStartPosition;
        //float rotateAroundX = -difference.y * rotateSpeed;
        //float rotateAroundY = difference.x * rotateSpeed;
        float rotateAroundZ = difference.z * rotateSpeed;
        //transform.Rotate(rotateAroundX, rotateAroundY, 0);
        transform.Rotate(0, 0, rotateAroundZ);
        mouseStartPosition = currentMousePosition;
        Debug.Log("OnMouseDrag");

    }
}
