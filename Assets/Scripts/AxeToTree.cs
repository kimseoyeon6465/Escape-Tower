using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeToTree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Tree"))
    //    {
    //        Debug.Log("collision");
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            if (other.gameObject.CompareTag("Tree"))
            {
                Debug.Log("collision");
            }
        }
    }

}
