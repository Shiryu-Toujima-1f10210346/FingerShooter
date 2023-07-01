using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;    
public class MoneySys : MonoBehaviour
{
    public static MoneySys instance;
    public int Balance;
    public TextMeshProUGUI MoneyText;
    public Text BalanceText;
    public void Awake()

    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
    Balance = 0;
    
    }

    // Update is called once per frame
    void Update()
    {
        if (MoneyText)
        {
            MoneyText.text = $"Earned Money :{Balance}$";
        }
        if(BalanceText == true)
        {
            BalanceText.text = $"Balance :{PlayerPrefs.GetInt("Balance")}$" ;

        }
    }
}
