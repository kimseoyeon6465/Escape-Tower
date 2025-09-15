using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnClickRestart()
    {
        Debug.Log("restart button clicked");
        SceneManager.LoadScene("Floor1");
    }
    public void OnClickExit()
    {
        Debug.Log("exit button clicked");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
