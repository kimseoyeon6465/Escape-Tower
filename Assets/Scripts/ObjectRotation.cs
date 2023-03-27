using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float rotationSpeed = 10f;

    private float mouseZ;

    void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");
        mouseZ += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, mouseZ);
    }
}
