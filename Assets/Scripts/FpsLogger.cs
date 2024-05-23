using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsLogger : MonoBehaviour
{
    public int fpsCounterSeconds;
    void Start()
    {
        
    }

    void Update()
    {
        int fps = (int) (1.0f / Time.unscaledDeltaTime);
        Debug.Log("FPS: " + fps);
    }
}
