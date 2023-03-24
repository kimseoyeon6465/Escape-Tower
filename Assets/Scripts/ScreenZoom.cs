using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenZoom : MonoBehaviour
{
    public Camera mainCamera;
    public float zoomSpeed = 1f;

    void Start()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;
    }

    public void ZoomIn()
    {
        mainCamera.fieldOfView -= zoomSpeed;
    }

    public void ZoomOut()
    {
        mainCamera.fieldOfView += zoomSpeed;
    }
}
