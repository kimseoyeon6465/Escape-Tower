using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour//이걸 포폴에 넣을수 있을까?
{
    public bool isDragging = false;
    private float distance;

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown 호출");
        Debug.Log(Camera.main.transform.position);

        isDragging = true;
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        //Debug.Log("distance"+distance);
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

