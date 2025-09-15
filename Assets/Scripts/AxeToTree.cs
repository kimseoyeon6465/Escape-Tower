using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeToTree : MonoBehaviour
{
    public GameObject TreeObject;
    public GameObject FireWoodPrefab;
    public GameObject firewood;
    void Start()
    {
        TreeObject = GameObject.Find("Tree");
    }

    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)//�浹�� ���� ��ġ�� ���� Instantiate�ϰ� ���� destroy
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            Debug.Log("collision");
            Vector3 TreePosition = TreeObject.transform.position;

            firewood = Instantiate(FireWoodPrefab, TreePosition, Quaternion.identity);
            Destroy(TreeObject);

        }
    }

}
