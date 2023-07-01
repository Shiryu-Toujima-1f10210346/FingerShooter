using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float originSpeed = 0.05f;
    public float speed;
    void Start()
    {
        
    }

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