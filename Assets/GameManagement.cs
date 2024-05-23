using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    // public Button btn;
    void Start()
    {
        // btn.onClick.AddListener(() => {
        //     startGame();
        // });
        Time.timeScale = 0;
    }

    void Update()
    {

    }

    public void startGame() {
        Debug.Log("Start");
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void pauseGame() {
        gameObject.SetActive(true);
        Time.timeScale = 0;
        
    }
}
