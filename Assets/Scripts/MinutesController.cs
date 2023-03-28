using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinutesController : MonoBehaviour
{
    private Vector3 mouseStartPosition;
    private float rotateSpeed = 5f;
    public float rotationSpeed = 500.0f;

    void OnMouseDown()
    {
        mouseStartPosition = Input.mousePosition;
        //Debug.Log("OnMouseDown");
    }

    void OnMouseDrag()
    {
        //Debug.Log("OnMouseDrag");

        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward, -rotationX);
    }
}
