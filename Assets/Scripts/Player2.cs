using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2 : MonoBehaviour//플레이어 회전 수정함. 점프구현 삭제해야함.
{
    public float moveSpeed;
    public float rotateSpeed;
    public float jumpPower;

    private Rigidbody charRigidbody;
    public bool isJumping = false;
    Animator anim;
    Vector3 movement;
    Vector3 pos;

    void Awake()
    {
        charRigidbody = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();

    }

    void FixedUpdate()
    {
        Run();
    }
    void Update()
    {
        //Jump();
        anim.SetBool("isWalk", movement != Vector3.zero);
        //Slide();
    }
    void Run()
    {
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(hAxis, 0, vAxis);

        // 바라보는 방향으로 회전 후 다시 정면을 바라보는 현상을 막기 위해 설정
        if (!(hAxis == 0 && vAxis == 0))
        {
            // 이동과 회전을 함께 처리
            transform.position += dir * moveSpeed * Time.deltaTime;
            // 회전하는 부분. Point 1.
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
        }
        movement.Set(hAxis, 0, vAxis);
        movement = movement.normalized * moveSpeed * Time.deltaTime;

        charRigidbody.MovePosition(transform.position + movement);
    }
    //void Jump()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
    //    {
    //        charRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    //        anim.SetBool("isJump", true);

    //        isJumping = true;
    //        //Debug.Log(isJumping);
    //    }

    //}
    void Slide()
    {
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("isSliding", true);
            //pos = this.gameObject.transform.position;
            //transform.Translate(new Vector3(pos.x, pos.y,pos.z + 1));
            //Debug.Log("Move Position");
        }
        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("isSliding", false);

        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        anim.SetBool("isJump", false);

    //        isJumping = false;
    //        //Debug.Log(isJumping);

    //    }
    //}
    
}

