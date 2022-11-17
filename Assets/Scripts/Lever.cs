using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject HighWater;
    public GameObject LowWater;
    public GameObject OpenDoor;
    public GameObject Wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HighWater.SetActive(false);
            LowWater.SetActive(true);
            Wall.SetActive(false);
            OpenDoor.SetActive(true);
        }
    }
}
