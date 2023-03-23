using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotCorrectLever : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Not Correct Lever Clicked");
        anim.SetBool("LeverDown", true);

        
    }
}
