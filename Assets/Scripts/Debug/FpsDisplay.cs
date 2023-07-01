using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FPSDisplay : MonoBehaviour
{

    // 変数
    public TextMeshProUGUI FPS;
    int frameCount;
    float prevTime;
    float fps;

    // 初期化処理
    void Start()
    {
        frameCount = 0;
        prevTime = 0.0f;
    }
    // 更新処理
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