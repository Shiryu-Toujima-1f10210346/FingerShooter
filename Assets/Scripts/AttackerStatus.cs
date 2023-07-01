using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerStatus : MonoBehaviour
{
    public float hp = 10;
    public int frame = 0;
    public float hpOrigin = 10;
    public float ATK;
    //float hpOrigin = gameObject.transform.localScale.x * 10;

    void Start()
    {
        hp = 100 / gameObject.transform.localScale.x;
        hpOrigin = hp;
    }

    void death()
    {
        Destroy(this.gameObject);
        Debug.Log("Destroyed");
    }
    
    // Update is called once per frame
    void Update()
    {
        hp -= 1.7f;
        if (hp <= 0)
        {
            death();
        }
        frame +=1;
        
    }
}
