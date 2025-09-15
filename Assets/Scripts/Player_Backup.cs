using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player3 : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    public float jumpPower;
    private Rigidbody charRigidbody;
    public Text text;
    public GameObject player;
    public bool isJumping = false;
    public int cubeCount = 0;
    int keyCount = 0;
    Animator anim;
    Vector3 movement;
    Vector3 pos;
    void Awake()
    {
        charRigidbody = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
        text = GameObject.Find("Keytext").GetComponent<Text>();
        player = GameObject.Find("Player");
        player.GetComponent<Player>().SetText();
    }

    void FixedUpdate()
    {
        Run();
    }
    void Update()
    {
        //Jump();
        anim.SetBool("isRun", movement != Vector3.zero);
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
    //void Slide()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        anim.SetBool("isSliding", true);
    //        //pos = this.gameObject.transform.position;
    //        //transform.Translate(new Vector3(pos.x, pos.y,pos.z + 1));
    //        //Debug.Log("Move Position");
    //    }
    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        anim.SetBool("isSliding", false);

    //    }
    //}
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        anim.SetBool("isJump", false);

    //        isJumping = false;
    //        //Debug.Log(isJumping);

    //    }
    //    if(collision.gameObject.CompareTag("Cube"))
    //    {
    //        cubeCount++;
    //        Destroy(collision.gameObject);
    //        Debug.Log(cubeCount);
    //    }
    //}
    //public void GetScore()
    //{
    //    keyCount += 1;
    //    Debug.Log(keyCount);
    //    SetText();
    //}

    //public void SetText()
    //{
    //    text.text = "Key : " + keyCount.ToString();//여기가 문제인데 왜인지 모르겠음
    //}
}
