using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    TMP_Text fpsText;
    public float fpsChangeAt = 5;
    // private const float SECONDS_MILI_CONVERSION = 1000; 
    private float fpsChangeTimer = 0;

    private GameObject menuPanel;

    // Start is called before the first frame update
    void Start()
    {
        Transform canvas = GameObject.Find("Canvas").transform;
        menuPanel = canvas.Find("StartGamePanel").gameObject;
        fpsText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return)) {
            menuPanel.GetComponent<GameManagement>().pauseGame();
        }

        fpsChangeTimer += Time.deltaTime;
        if (fpsChangeTimer > fpsChangeAt) {
            int fps = (int)(1f / Time.unscaledDeltaTime);
            // Debug.Log(fps);
            fpsText.text = "FPS: " + fps;
            fpsChangeTimer = 0;
        }
    }
}
