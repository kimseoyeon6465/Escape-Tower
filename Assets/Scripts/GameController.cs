using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text text;
    int keyCount = 0;

    private void Start()
    {
        SetText();
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
