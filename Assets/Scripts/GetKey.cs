using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKey : MonoBehaviour
{
    private Text text;
    public GameObject player;
    //int keyCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Keytext").GetComponent<Text>();
        player = GameObject.Find("Player");
        player.GetComponent<Player>().SetText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()//열쇠를 클릭하면 열쇠 카운트 증가, 열쇠 갯수 채우면 게임 종료
    {
        Debug.Log("key is clicked");
        GameObject stage3Door = GameObject.Find("wall39");

        player.GetComponent<Player>().GetScore();
        Destroy(this.gameObject);
        Destroy(stage3Door);

    }
}
   

