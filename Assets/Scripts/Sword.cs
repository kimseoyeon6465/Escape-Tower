using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sword : MonoBehaviour
{
    public GameObject gameClearPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameClearPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 180 * Time.deltaTime);
    }
    private void OnMouseDown()
    {
        Debug.Log("Sword is clicked");
        SceneManager.LoadScene("GameClear");
    }
    public void GameClear()
    {
        gameClearPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
