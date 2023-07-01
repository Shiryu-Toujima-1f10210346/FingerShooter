using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FPSDisplay : MonoBehaviour
{

    // �ϐ�
    public TextMeshProUGUI FPS;
    int frameCount;
    float prevTime;
    float fps;

    // ����������
    void Start()
    {
        frameCount = 0;
        prevTime = 0.0f;
    }
    // �X�V����
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