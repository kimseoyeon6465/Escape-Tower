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
    void OnMouseDown()//���踦 Ŭ���ϸ� ���� ī��Ʈ ����, ���� ���� ä��� ���� ����
    {
        Debug.Log("key is clicked");
        GameObject stage3Door = GameObject.Find("wall39");

        player.GetComponent<Player>().GetScore();
        Destroy(this.gameObject);
        Destroy(stage3Door);

    }
}
   

