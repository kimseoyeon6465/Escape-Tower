using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKey : MonoBehaviour
{
    public Text text;
    int keyCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()//열쇠를 클릭하면 열쇠 카운트 증가, 열쇠 갯수 채우면 게임 종료
    {
        Debug.Log("key is clicked");
        GetScore();
        Destroy(this.gameObject);
    }
    public void GetScore()
    {
        keyCount += 1;
        Debug.Log(keyCount);
        SetText();
    }

    public void SetText()
    {
        text.text = "Key : " + keyCount.ToString();
    }
}
