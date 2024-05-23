using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsLoggerLab3 : MonoBehaviour
{
    public int fpsShowTime = 1;
    private float fpsShowTimer = 0f;

    void Start()
    {

    }

    void Update()
    {
        fpsShowTimer += Time.unscaledDeltaTime;
        if (fpsShowTimer > fpsShowTime) {
            fpsShowTimer = 0;
            int fps = (int) (1f / Time.deltaTime);
            Debug.Log("FPS: " + fps);
        }
    }
}
