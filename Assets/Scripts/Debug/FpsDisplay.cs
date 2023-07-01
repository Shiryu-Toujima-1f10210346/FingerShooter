using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FPSDisplay : MonoBehaviour
{

    // •Ï”
    public TextMeshProUGUI FPS;
    int frameCount;
    float prevTime;
    float fps;

    // ‰Šú‰»ˆ—
    void Start()
    {
        frameCount = 0;
        prevTime = 0.0f;
    }
    // XVˆ—
    void Update()
    {
        frameCount++;
        float time = Time.realtimeSinceStartup - prevTime;

        if (time >= 0.5f)
        {
            fps = frameCount / time;
            FPS.text = "FPS:" + ((int)fps).ToString();
            frameCount = 0;
            prevTime = Time.realtimeSinceStartup;
        }
    }
}