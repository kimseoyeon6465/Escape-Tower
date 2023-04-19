using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewoodCollision : MonoBehaviour
{
    public GameObject FirewoodObject;
    public GameObject FirePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //FirewoodObject = GameObject.Find("Firewood_B(Clone)");
        //SnowMan=GameObject.Find("Snow Man_01");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Firewood"))
        {
            Debug.Log("Firewood collision");
            Vector3 FirewoodPosition = this.gameObject.transform.position;
            GameObject fire = Instantiate(FirePrefab, FirewoodPosition, Quaternion.identity);
            //여기서 Destroy를 해야하지 않나?
            //Destroy(객체);
            Destroy(this.gameObject);

        }
    }
}
