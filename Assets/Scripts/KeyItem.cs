using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();

    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            gameController.GetScore();

            Destroy(gameObject);
        }
    }
}
