using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        
    }

    public void startGame() {
        Debug.Log("Start Game");
        GameObject mainMenu = GameObject.Find("Canvas/MainMenu");
        mainMenu.SetActive(false);
        Time.timeScale = 1;
        // gameObject.SetActive(false);
    }
}
