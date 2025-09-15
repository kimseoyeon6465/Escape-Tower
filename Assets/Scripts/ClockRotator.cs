using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotator : MonoBehaviour
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
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Ãæµ¹");
        GameObject stage2Door = GameObject.Find("wall40");
        Destroy(stage2Door);
    }
}

