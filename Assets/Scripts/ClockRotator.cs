using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotator : MonoBehaviour
{
    private Vector3 mouseStartPosition;
    private float rotateSpeed = 5f;
    public float rotateAroundX;
    public float rotateAroundY;
    public float rotateAroundZ;
    void OnMouseDown()
    {
        mouseStartPosition = Input.mousePosition;
        //Debug.Log("OnMouseDown");
    }

    void OnMouseDrag()
    {
        Vector3 currentMousePosition = Input.mousePosition;
        Vector3 difference = currentMousePosition - mouseStartPosition;
        rotateAroundX = -difference.y * rotateSpeed;
        rotateAroundY = difference.x * rotateSpeed;
        rotateAroundZ = difference.z * rotateSpeed;
        //transform.Rotate(rotateAroundX, 0, 0);
        transform.Rotate(0, 0, rotateAroundZ);
        //Quaternion temp = new Quaternion(0, 0, rotateAroundZ);
        //this.transform.localRotation = temp;
        mouseStartPosition = currentMousePosition;
        //Debug.Log("OnMouseDrag");
        Debug.Log("currentMousePosition"+currentMousePosition);
        Debug.Log("difference"+ difference);
        Debug.Log("Input mousePosition"+ Input.mousePosition);
        Debug.Log("mouseStartPosition"+ mouseStartPosition);

    }
}
