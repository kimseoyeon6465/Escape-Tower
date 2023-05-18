using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeytoBox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ClosedBoxObject;
    public GameObject OpenBoxPrefab;
    public GameObject openbox;
    AudioSource audioSource;
    void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }
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
            this.audioSource.Play();
            Vector3 BoxPosition = ClosedBoxObject.transform.position;
            openbox = Instantiate(OpenBoxPrefab, BoxPosition, Quaternion.Euler(0,180.0f,0));
            //openbox = Instantiate(OpenBoxPrefab, BoxPosition, Quaternion.identity);
            Destroy(ClosedBoxObject);
        }
    }
}
