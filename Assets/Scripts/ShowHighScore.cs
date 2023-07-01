using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighScore : MonoBehaviour
{
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = $"No1:{PlayerPrefs.GetInt("ScoreNo1")}\nNo2:{PlayerPrefs.GetInt("ScoreNo2")}\nNo3:{PlayerPrefs.GetInt("ScoreNo3")}\nNo4:{PlayerPrefs.GetInt("ScoreNo4")}\nNo5:{PlayerPrefs.GetInt("ScoreNo5")}";
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
