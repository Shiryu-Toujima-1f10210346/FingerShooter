using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalScore : MonoBehaviour
{
    // Start is called before the first frame update

    public Text scoreText;

    
    void Start()
    {
        scoreText.text = string.Format("Score:{0}", ScoreScript.instance.scoreNum.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
