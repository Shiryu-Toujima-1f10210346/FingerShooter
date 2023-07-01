using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowBestScore : MonoBehaviour
{
    public Text BestScore;
    // Start is called before the first frame update
    void Start()
    {
        BestScore.text = $"{PlayerPrefs.GetInt("ScoreNo1")}";
    }
}