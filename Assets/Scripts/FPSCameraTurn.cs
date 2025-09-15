using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCameraTurn : MonoBehaviour
{
    public float turnSpeed = 4.0f; // ���콺 ȸ�� �ӵ�


    private float xRotate = 0.0f; // ���� ����� X�� ȸ������ ���� ���� ( ī�޶� �� �Ʒ� ���� )

    void Start()
    {
        
    }

    void Update()
    {
        if (Time.timeScale != 0)
        {
            MouseRotation();

        }
    }
    void MouseRotation()
    {

        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        float yRotate = transform.eulerAngles.y + yRotateSize;

        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;

        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);

        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
    }
}
