using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewoodCollision : MonoBehaviour
{
    public GameObject FirewoodObject;
    public GameObject FirePrefab;
    public GameObject SnowMan;
    // Start is called before the first frame update
    void Start()
    {
        //FirewoodObject = GameObject.Find("Firewood_B(Clone)");
        SnowMan=GameObject.FindWithTag("Snowman");

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
            //���⼭ Destroy�� �ؾ����� �ʳ�?
            //Destroy(��ü);
            Invoke("DestroySnowMan", 3f);
            //���ؾ����� �𸣰���
            //������ �� �ؾ����� �𸣰���

            //Destroy(this.gameObject);

        }
    }
    void DestroySnowMan()
    {
        Destroy(SnowMan);
        Debug.Log("3�� ������ ȣ��");
    }
}
