using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBall : MonoBehaviour
{
    public float originSpeed = 0.01f;
    public float speed;

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("HP HEALED");
        if (other.gameObject.CompareTag("Player") && attack.instance.isButtonDowned == false)
        {   if (DeadLine.instance.playerHP < DeadLine.instance.maxHP)
            {
                DeadLine.instance.playerHP += 1;
            }
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Top"))
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {

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