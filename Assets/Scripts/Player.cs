using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    Rigidbody rigidbody;
    public float speed;
    public float rotateSpeed;
    float horizontalMove;
    float verticalMove;
    GameController gameController;

    Vector3 movement;
    Animator animator;
    // Start is called before the first frame update

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        animator = GetComponentInChildren<Animator>();
    }
    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        //movement = new Vector3(horizontalMove, 0, verticalMove).normalized;
        //transform.position += movement * speed * Time.deltaTime;
        //animator.SetBool("isWalk", movement != Vector3.zero);
        AnimationUpdate();
    }
    void FixedUpdate()
    {
        Turn();
        Run();

    }
    void Turn()
    {
        if (horizontalMove == 0 && verticalMove == 0)
            return;
        Quaternion newRotation = Quaternion.LookRotation(movement);
        rigidbody.rotation = Quaternion.Slerp(rigidbody.rotation, newRotation, rotateSpeed * Time.deltaTime);
        //rigidbody.MoveRotation(newRotation);
    }
    void Run()
    {
        movement=new Vector3(horizontalMove, 0, verticalMove).normalized;
        movement = movement.normalized * speed * Time.deltaTime;

        rigidbody.MovePosition(transform.position + movement);
    }
    void AnimationUpdate()
    {
        if (horizontalMove == 0 && verticalMove == 0)
            animator.SetBool("isWalk", false);
        else
            animator.SetBool("isWalk", true);
    }
    void OnCollisionEnter(Collision collision)
    {
        //    if (collision.gameObject.CompareTag("Door"))
        //    {
        //        SceneManager.LoadScene("3x3Puzzle");
        //}
        if (collision.gameObject.CompareTag("DoorToFloor1"))
        {
            SceneManager.LoadScene("Floor1");

        }
    }
    //private void OnTriggerEnter(Collider collision)
    //{
    //    if(collision.tag=="Key")
    //    {
    //    }
    //}
}
