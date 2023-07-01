using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public int count = 0;
    public Vector3 prevMousePos;
    public Vector3 mousePos;
    public int frame = 0;
    public bool isButtonDowned = false;
    public static attack instance;
    public GameObject EnergyParticle;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Update()
    {
        GameObject atk = (GameObject)Resources.Load("Attacker");
        if (Input.GetMouseButtonDown(0) && Energy.instance.nowEnergy > 0 )//&& Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 3.0f)
        {
            prevMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isButtonDowned = true;
            Vector3 pos = Input.mousePosition;
            pos.z = 10.0f;
            GameObject hoge = Instantiate(atk, Camera.main.ScreenToWorldPoint(pos), Quaternion.identity);
            pos.z = 11.0f;
            EnergyParticle = Instantiate((GameObject)Resources.Load("EnergyParticle"), Camera.main.ScreenToWorldPoint(pos), Quaternion.identity);

            count++;
            hoge.name = hoge.name.Replace("(Clone)", count.ToString());
        }
        if (Input.GetMouseButton(0) && this.gameObject != null && Energy.instance.nowEnergy > 0)
        {

            string n = string.Format("Attacker{0}", count.ToString());
            if (GameObject.Find(n).transform.localScale.x < 3)
            {
                GameObject.Find(n).transform.localScale += new Vector3(0.02f, 0.02f, 0);
            }

        }
        if (Input.GetMouseButtonUp(0) && this.gameObject != null && Energy.instance.nowEnergy > 0)
        {
            Energy.instance.nowEnergy--;
            isButtonDowned = false;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            string n = string.Format("Attacker{0}", count.ToString());
            GameObject.Find(n).GetComponent<Rigidbody2D>().velocity = (mousePos - prevMousePos) / GameObject.Find(n).transform.localScale.x;
            GameObject.Find(n).GetComponent<AttackerStatus>().ATK = GameObject.Find(n).transform.localScale.x * 2;
            Destroy(EnergyParticle);
        }

        frame += 1;
    }
}