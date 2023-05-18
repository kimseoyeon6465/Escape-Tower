using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCameraMoveOnly : MonoBehaviour
{

    float speed = 10f;

    Rigidbody rigidbody;
    Vector3 movement;
    float h, v;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        rigidbody.MovePosition(transform.position + movement);
    }
    //void Run1()
    //{
    //    float hAxis = Input.GetAxisRaw("Horizontal");
    //    float vAxis = Input.GetAxisRaw("Vertical");

    //    Vector3 dir = new Vector3(hAxis, 0, vAxis);

    //    // �ٶ󺸴� �������� ȸ�� �� �ٽ� ������ �ٶ󺸴� ������ ���� ���� ����
    //    if (!(hAxis == 0 && vAxis == 0))
    //    {
    //        //// �̵��� ȸ���� �Բ� ó��
    //        //transform.position += dir * moveSpeed * Time.deltaTime;
    //        //// ȸ���ϴ� �κ�. Point 1.
    //        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
    //        return;
    //    }
    //    movement.Set(hAxis, 0, vAxis);
    //    movement = movement.normalized * moveSpeed * Time.deltaTime;

    //    charRigidbody.MovePosition(transform.position + movement);
    //    Quaternion newRotation = Quaternion.LookRotation(movement);
    //    charRigidbody.rotation = Quaternion.Slerp(charRigidbody.rotation, newRotation, rotateSpeed * Time.deltaTime);
    //}
    //void Run()
    //{
    //    float hAxis = Input.GetAxisRaw("Horizontal");
    //    float vAxis = Input.GetAxisRaw("Vertical");

    //    Vector3 dir = new Vector3(hAxis, 0, vAxis);

    //    // �ٶ󺸴� �������� ȸ�� �� �ٽ� ������ �ٶ󺸴� ������ ���� ���� ����
    //    if (!(hAxis == 0 && vAxis == 0))
    //    {
    //        // �̵��� ȸ���� �Բ� ó��
    //        transform.position += dir * moveSpeed * Time.deltaTime;
    //        // ȸ���ϴ� �κ�. Point 1.
    //        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
    //    }
    //    movement.Set(hAxis, 0, vAxis);
    //    movement = movement.normalized * moveSpeed * Time.deltaTime;

    //    charRigidbody.MovePosition(transform.position + movement);
    //}
    //public float Speed = 10.0f;

    //public float rotateSpeed = 10.0f;       // ȸ�� �ӵ�

    //float h, v;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    //// �̵� ���� �Լ��� © ���� Update���� FixedUpdate�� �� ȿ���� ���ٰ� �Ѵ�. �׷��� ����ߴ�.
    //void FixedUpdate()
    //{
    //    h = Input.GetAxis("Horizontal");
    //    v = Input.GetAxis("Vertical");

    //    Vector3 dir = new Vector3(h, 0, v); // new Vector3(h, 0, v)�� ���� ���̰� �Ǿ����Ƿ� dir�̶�� ������ �ְ� ���� ���ϰ� ����� �� �ְ� ��

    //    // �ٶ󺸴� �������� ȸ�� �� �ٽ� ������ �ٶ󺸴� ������ ���� ���� ����
    //    if (!(h == 0 && v == 0))
    //    {
    //        // �̵��� ȸ���� �Բ� ó��
    //        transform.position += dir * Speed * Time.deltaTime;
    //        // ȸ���ϴ� �κ�. Point 1.
    //        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
    //    }
    //}
}
