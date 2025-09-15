using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotCorrectLever : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();

    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Not Correct Lever Clicked");
        anim.SetBool("LeverDown", true);

        
    }
}
