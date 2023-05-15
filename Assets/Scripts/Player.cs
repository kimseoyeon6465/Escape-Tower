using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    Rigidbody rigidbody;
    public float moveSpeed;

    public float speed;
    public float rotateSpeed;
    public Text text;

    //public bool isWalk = false;
    float horizontalInput;
    float verticalInput;
    GameController gameController;

    Vector3 movement;
    Vector3 movementDirection;
    Animator animator;

    int keyCount = 0;


    // Start is called before the first frame update
    //뭘 해야하나
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();
        text = GameObject.Find("Keytext").GetComponent<Text>();

    }
    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }
    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal");
        //verticalMove = Input.GetAxisRaw("Vertical");

        //animator.SetBool("isWalk", movement != Vector3.zero);

        //AnimationUpdate();
        //Debug.Log(animator.GetBool("isWalk"));
        GetInput();
        Move();
        Turn();

    }
    void FixedUpdate()
    {
        //Turn();
        //Run();
        //Run2();
       
    }
    void Turn()
    {
        if (movementDirection.magnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movementDirection);
            rigidbody.MoveRotation(Quaternion.RotateTowards(rigidbody.rotation, targetRotation, 200f * Time.fixedDeltaTime));
        }
    }
    //void Run()
    //{
    //    movement = new Vector3(horizontalMove, 0, verticalMove).normalized;
    //    movement = movement.normalized * speed * Time.deltaTime;

    //    rigidbody.MovePosition(transform.position + movement);
    //}
    void Run2()
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

        rigidbody.MovePosition(transform.position + movement);
    }
    void TurnandRun()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // calculate the movement direction based on input
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // move the player based on the movement direction and speed
        rigidbody.MovePosition(transform.position + movementDirection * speed * Time.fixedDeltaTime);

        // rotate the player to face the movement direction
        if (movementDirection.magnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movementDirection);
            rigidbody.MoveRotation(Quaternion.RotateTowards(rigidbody.rotation, targetRotation, 200f * Time.fixedDeltaTime));
        }
    }
    void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        rigidbody.MovePosition(transform.position + movementDirection * speed * Time.fixedDeltaTime);
        animator.SetBool("isWalk", movementDirection != Vector3.zero);
    }
    //void AnimationUpdate()
    //{
    //    Debug.Log(horizontalMove);
    //    Debug.Log(verticalMove);
    //    if (horizontalMove == 0 && verticalMove == 0)
    //    {
    //        animator.SetBool("isWalk", false);

    //    }
    //    else
    //    {
    //        animator.SetBool("isWalk", true);
    //        Debug.Log("else문 걸림");


    //    }
        //void OnCollisionEnter(Collision collision)
        //{
        //    //    if (collision.gameObject.CompareTag("Door"))
        //    //    {
        //    //        SceneManager.LoadScene("3x3Puzzle");
        //    //}
        //    if (collision.gameObject.CompareTag("DoorToFloor1"))
        //    {
        //        SceneManager.LoadScene("Floor1");

        //    }
        //}
        //private void OnTriggerEnter(Collider collision)
        //{
        //    if(collision.tag=="Key")
        //    {
        //    }
        //}
public void GetScore()
{
    keyCount += 1;
    Debug.Log(keyCount);
    SetText();
}
public void SetText()
{
    text.text = "Key : " + keyCount.ToString();//여기가 문제인데 왜인지 모르겠음
}
}



