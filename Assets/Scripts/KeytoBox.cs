using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeytoBox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ClosedBoxObject;
    public GameObject OpenBoxPrefab;
    public GameObject openbox;
    void Start()
    {
        ClosedBoxObject = GameObject.Find("box10");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Box"))
        {
            Debug.Log("box key collision");
            Vector3 BoxPosition = ClosedBoxObject.transform.position;
            openbox = Instantiate(OpenBoxPrefab, BoxPosition, Quaternion.Euler(0,180.0f,0));
            //openbox = Instantiate(OpenBoxPrefab, BoxPosition, Quaternion.identity);
            Destroy(ClosedBoxObject);
        }
    }
}
