using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject menuPanel;
    void Start()
    {
        menuPanel.SetActive(false);

    }

    void Update()
    {
        
    }
    public void MenuButtonClicked()
    {
        //Debug.Log("Button Clicked");
        menuPanel.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void MenuExitClicked()
    {
        Debug.Log("button clicked");
        menuPanel.SetActive(false);
        Time.timeScale = 1;

    }
}
