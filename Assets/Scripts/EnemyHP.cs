using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public float hp = 10;
    public int frame = 0;
    public float hpOrigin = 10;
    public GameObject deathParticle;
    public AudioClip destroySound;
    AudioSource audioSource;
     
    
    
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && frame % 5 == 0 && attack.instance.isButtonDowned == false)
        {
            hp -= other.gameObject.GetComponent<AttackerStatus>().ATK;　//AttackerのATKを参照したい
            //hp -= 1;
            other.gameObject.GetComponent<Rigidbody2D>().velocity *= 0.9f;
            //this.gameObject.transform.localScale -= new Vector3(0.2f, 0.2f,0.0f); 　小さくするならこっち
            this.gameObject.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, 1 - (hp / hpOrigin));
            frame = 0;

        }
        if (other.gameObject.CompareTag("Top"))
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hp = gameObject.transform.localScale.x * 10;
        hpOrigin = hp;
        deathParticle = (GameObject)Resources.Load("DeathParticle");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.gameObject.GetComponent<SpriteRenderer>().color.a <= 0.2f  )
        {
            //audioSource.PlayOneShot(destroySound);
            GameObject particle =Instantiate(deathParticle, this.gameObject.transform.position, Quaternion.identity);
            particle.transform.localScale = new Vector2(this.gameObject.transform.localScale.x/2, this.gameObject.transform.localScale.y/2);
            audioSource.PlayOneShot(destroySound);
            GameObject.FindObjectOfType<AudioSource>().PlayOneShot(destroySound);
            Destroy(this.gameObject);
            ScoreScript.instance.scoreNum += 1+ (int)this.gameObject.transform.localScale.x*2;
            
        }
        /* (hp <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Destroyed");
        }透明度0.1f以下になると見えなくなるので上に変更*/
        frame +=1;
    }
}