using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour//
{
    public bool isDragging = false;
    private float distance;

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown »£√‚");
        Debug.Log(Camera.main.transform.position);

        isDragging = true;
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);

    }
    
    void OnMouseUp()
    {
        isDragging = false;
    }
    
    void Update()
    {
        //Debug.Log(isDragging);
        if (isDragging)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            //Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = worldPosition;
        }
        //print(transform.position);

    }

}

