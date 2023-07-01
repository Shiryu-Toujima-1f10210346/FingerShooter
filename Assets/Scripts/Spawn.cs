using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int frameCount = 0;
    public int EnergyRandomCount;
    //public int diff;
    // Start is called before the first frame update
    void Start()
    {
        //diff = 1;
    }

    // Update is called once per frame
    void Update()
    {
        EnergyRandomCount = Random.Range(0, 3000);
        frameCount += 1;
        //diff = 1+(int)ScoreScript.instance.scoreNum / 10;‚æ‚­‚í‚©‚ç‚ñ‚­‚È‚Á‚½
        //if (frameCount % 61 - diff == 0)
        if(frameCount == 60)
        {
            float randX = Random.Range(0.1f, 5.0f);
            float randScale = Random.Range(0.7f, 2f);
            GameObject obj = (GameObject)Resources.Load("Enemy");
            frameCount = 0;
            GameObject enemy = Instantiate(obj, new Vector2(randX, 10), Quaternion.identity);
            enemy.transform.localScale = new Vector2(randScale, randScale);
            enemy.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 0.9f);
        }
        
        if (EnergyRandomCount == 1)//EnergyBall spawn
        {
            float randX = Random.Range(0.1f, 5.0f);
            float Scale = 1.0f;
            GameObject obj = (GameObject)Resources.Load("EnergyBall");
            GameObject energy = Instantiate(obj, new Vector2(randX, 10), Quaternion.identity);
            energy.transform.localScale = new Vector2(Scale, Scale);
        }

        if (EnergyRandomCount == 2 || EnergyRandomCount == 3)//HPBall spawn
        {
            float randX = Random.Range(0.1f, 5.0f);
            float Scale = 1.0f;
            GameObject obj = (GameObject)Resources.Load("HPBall");
            GameObject hpball = Instantiate(obj, new Vector2(randX, 10), Quaternion.identity);
            hpball.transform.localScale = new Vector2(Scale, Scale);
        }
        if (EnergyRandomCount == 4 || EnergyRandomCount == 5 || EnergyRandomCount == 6)//MoneyBall spawn
        {
            float randX = Random.Range(0.1f, 5.0f);
            float Scale = 1.0f;
            GameObject obj = (GameObject)Resources.Load("MoneyBall");
            GameObject moneyball = Instantiate(obj, new Vector2(randX, 10), Quaternion.identity);
            moneyball.transform.localScale = new Vector2(Scale, Scale);
        }
    }
}
