using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeToTree : MonoBehaviour
{
    public GameObject TreeObject;
    public GameObject FireWoodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        TreeObject = GameObject.Find("Tree");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)//충돌시 나무 위치에 장작 Instantiate하고 나무 destroy
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            Debug.Log("collision");
            Vector3 TreePosition = TreeObject.transform.position;

            GameObject firewood = Instantiate(FireWoodPrefab, TreePosition, Quaternion.identity);
            Destroy(TreeObject);

        }
    }

}
