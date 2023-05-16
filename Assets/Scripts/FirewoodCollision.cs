using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewoodCollision : MonoBehaviour
{
    public GameObject FirewoodObject;
    public GameObject FirePrefab;
    public GameObject KeyPrefab;
    public GameObject SnowMan;
    private float targetScale = 0.25f;
    private float duration = 2f;
    // Start is called before the first frame update
    void Start()
    {
        FirewoodObject = GameObject.Find("Firewood_B(Clone)");
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
            Vector3 SnowManPosition = SnowMan.transform.position;
            GameObject fire = Instantiate(FirePrefab, FirewoodPosition, Quaternion.identity);
            //여기서 Destroy를 해야하지 않나?
            //Destroy(객체);
            //Invoke("DestroySnowMan", 3f);
            //Invoke("ResizeSnowman", 3f);
            StartCoroutine(ResizeObjectOverTime(SnowMan,targetScale, duration));
            GameObject key = Instantiate(KeyPrefab, SnowManPosition, Quaternion.identity);
            Debug.Log("key Instantiate");
            GameObject doorToOut = GameObject.Find("doorway5");
            Destroy(doorToOut);
        
        }
    }
    void DestroySnowMan()
    {
        Destroy(SnowMan);
        Debug.Log("3초 지나서 호출");
    }
    void ResizeSnowman()
    {
        SnowMan.transform.localScale *= 0.8f;

    }
    public IEnumerator ResizeObjectOverTime(GameObject targetObject, float targetScale, float duration)
    {
        //Debug.Log("코루틴 호출");
        Transform objectTransform = targetObject.GetComponent<Transform>();
        Vector3 initialScale = objectTransform.localScale;
        Vector3 targetScaleVector = new Vector3(targetScale, targetScale, targetScale);

        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            //Debug.Log("while문 걸림");
            objectTransform.localScale = Vector3.Lerp(initialScale, targetScaleVector, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        objectTransform.localScale = targetScaleVector; // 최종 크기로 설정
        yield return new WaitForSeconds(3f);
    }
}
