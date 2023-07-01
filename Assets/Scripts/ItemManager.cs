using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("ScoreUp50") == 1)
        {
            ScoreScript.instance.scoreNum += 50;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
