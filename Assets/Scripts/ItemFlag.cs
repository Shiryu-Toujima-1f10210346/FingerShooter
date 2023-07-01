using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemFlag : MonoBehaviour
{
    public TextMeshProUGUI ScoreUp50Text;
    public static ItemFlag instance;

    public void Awake()

    {
        if (instance == null)
        {
            instance = this;
        }
    }

    /*template
     public void FuncName(){
    if (PlayerPrefs.HasKey("ButtonName") == false || PlayerPrefs.GetInt("ButtonName") == 0)//èâÇﬂÇƒâüÇµÇΩ or false
        {
            PlayerPrefs.SetInt("ButtonName", 1);
            PlayerPrefs.Save();
            //GameObject.Find("ButtonName").GetComponent<Button>().image.color = Color.blue;
            ButtonNameText.text = "ButtonName:ON";
            Debug.Log("ButtonName--ON");
        }
        else
        {
            PlayerPrefs.SetInt("ButtonName", 0);
            PlayerPrefs.Save();
            //GameObject.Find("ButtonName").GetComponent<Button>().image.color = Color.red;
            ButtonNameText.text = "ButtonName:OFF";
            Debug.Log("ButtonName--OFF");
        }
     */
    public void OnClickScoreUp50()
    {
        if (PlayerPrefs.HasKey("ScoreUp50") == false || PlayerPrefs.GetInt("ScoreUp50") == 0)//èâÇﬂÇƒâüÇµÇΩ or false
        {
            PlayerPrefs.SetInt("ScoreUp50", 1);
            PlayerPrefs.Save();
            //GameObject.Find("ScoreUp50").GetComponent<Button>().image.color = Color.blue;
            ScoreUp50Text.text = "Score+50:ON";
            Debug.Log("ScoreUp50--ON");
        }
        else
        {
            PlayerPrefs.SetInt("ScoreUp50", 0);
            PlayerPrefs.Save();
            //GameObject.Find("ScoreUp50").GetComponent<Button>().image.color = Color.red;
            ScoreUp50Text.text = "Score+50:OFF";
            Debug.Log("ScoreUp50--OFF");
        }
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("ScoreUp50") == 0)//èâÇﬂÇƒâüÇµÇΩ or false
        {
            //GameObject.Find("ScoreUp100").GetComponent<Button>().image.color = Color.red;
            ScoreUp50Text.text = "Score+50:OFF";
        }
        else
        {
            //GameObject.Find("ScoreUp100").GetComponent<Button>().image.color = Color.blue;
            ScoreUp50Text.text = "Score+50:ON";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
