using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoneyBall : MonoBehaviour
{
    public float originSpeed = 0.02f;
    public float speed;

    void OnTriggerStay2D(Collider2D other)

    {
        if (other.gameObject.CompareTag("Player")&& attack.instance.isButtonDowned == false)
        {
            Debug.Log("MONEY EARNED");
            MoneySys.instance.Balance += 100;//MoneyŠl“¾
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Top"))
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        if (PlayerPrefs.HasKey("Balance") != false) PlayerPrefs.SetInt("Balance", 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 scale = gameObject.transform.localScale;
        speed = originSpeed / scale.x;
        ////speed up
        if (ScoreScript.instance.scoreNum != 0)
        {
            speed += (float)ScoreScript.instance.scoreNum / 5000;
        }
        ///
        Vector2 position = transform.position;
        position.y -= speed;
        transform.position = position;
    }
}
