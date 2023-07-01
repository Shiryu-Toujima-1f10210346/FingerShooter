using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DeadLine : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerHP;
    public int maxHP = 5;
    public Text playerHPText;
    string hp;
    public static DeadLine instance;
    public void Awake()

    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerHP -= 1;
            playerHPText.text = string.Format("HP = {0}", playerHP.ToString());
        }
        if (playerHP <= 0)
        {
            PlayerPrefs.SetInt("Balance", PlayerPrefs.GetInt("Balance")+MoneySys.instance.Balance);
            if (PlayerPrefs.HasKey("ScoreNo1") == false)
            {
                PlayerPrefs.SetInt("ScoreNo1", 0);
            }
            if (PlayerPrefs.HasKey("ScoreNo2") == false)
            {
                PlayerPrefs.SetInt("ScoreNo2", 0);
            }
            if (PlayerPrefs.HasKey("ScoreNo3") == false)
            {
                PlayerPrefs.SetInt("ScoreNo3", 0);
            }
            if (PlayerPrefs.HasKey("ScoreNo4") == false)
            {
                PlayerPrefs.SetInt("ScoreNo4", 0);
            }
            if (PlayerPrefs.HasKey("ScoreNo5") == false)
            {
                PlayerPrefs.SetInt("ScoreNo5", 0);
            }
            switch (ScoreScript.instance.scoreNum)
            {
                case int theScore when(theScore > PlayerPrefs.GetInt("ScoreNo1")):
                    PlayerPrefs.SetInt("ScoreNo5", PlayerPrefs.GetInt("ScoreNo4"));
                    PlayerPrefs.SetInt("ScoreNo4", PlayerPrefs.GetInt("ScoreNo3"));
                    PlayerPrefs.SetInt("ScoreNo3", PlayerPrefs.GetInt("ScoreNo2"));
                    PlayerPrefs.SetInt("ScoreNo2", PlayerPrefs.GetInt("ScoreNo1"));
                    PlayerPrefs.SetInt("ScoreNo1", theScore);
                    break;
                case int theScore when(theScore > PlayerPrefs.GetInt("ScoreNo2")):
                    PlayerPrefs.SetInt("ScoreNo5", PlayerPrefs.GetInt("ScoreNo4"));
                    PlayerPrefs.SetInt("ScoreNo4", PlayerPrefs.GetInt("ScoreNo3"));
                    PlayerPrefs.SetInt("ScoreNo3", PlayerPrefs.GetInt("ScoreNo2"));
                    PlayerPrefs.SetInt("ScoreNo2", theScore);
                    break;
                case int theScore when(theScore > PlayerPrefs.GetInt("ScoreNo3")):
                    PlayerPrefs.SetInt("ScoreNo5", PlayerPrefs.GetInt("ScoreNo4"));
                    PlayerPrefs.SetInt("ScoreNo4", PlayerPrefs.GetInt("ScoreNo3"));
                    PlayerPrefs.SetInt("ScoreNo3", theScore);
                    break;
                case int theScore when(theScore > PlayerPrefs.GetInt("ScoreNo4")):
                    PlayerPrefs.SetInt("ScoreNo5", PlayerPrefs.GetInt("ScoreNo4"));
                    PlayerPrefs.SetInt("ScoreNo4", theScore);
                    break;
                case int theScore when(theScore > PlayerPrefs.GetInt("ScoreNo5")):
                    PlayerPrefs.SetInt("ScoreNo5", theScore);
                    break;
            }
            PlayerPrefs.Save();
            SceneManager.LoadScene("GameOver");
        }
    }


    void Start()
    {
        hp = string.Format("HP = {0}", playerHP.ToString());
        playerHPText.text = hp;
        playerHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP == 0)
        {
            GameObject.Find("HitPointBar").transform.position = new Vector3(-3, 0.1f, 0);
        }
        else if (maxHP != playerHP)
        {
            GameObject.Find("HitPointBar").transform.position = new Vector3(playerHP * 6 / maxHP - 3.0f, 0.1f, 0);
        }
        else
        {
            GameObject.Find("HitPointBar").transform.position = new Vector3(3, 0.1f, 0);
        }
    }
}
