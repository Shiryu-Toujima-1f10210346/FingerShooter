using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Energy : MonoBehaviour
{
    // Start is called before the first frame update

    public int maxEnergy = 8;
    public Text nowEnergyText;
    public int nowEnergy;
    public int frame = 0;
    public static Energy instance;
    public void Awake()

    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        nowEnergy = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        nowEnergyText.text = string.Format("Energy:{0}", nowEnergy.ToString());
        if (nowEnergy == 0)
        {
            this.gameObject.transform.position = new Vector3(-3, 0.35f, 0);
        }
        else if (maxEnergy != nowEnergy)
        {
            this.gameObject.transform.position = new Vector3(nowEnergy * 6 / maxEnergy - 3.0f, 0.35f, 0);
        }
        else
        {
            this.gameObject.transform.position = new Vector3(3, 0.35f, 0);
        }
        if (frame == 90)//•â‹‹
        {
            if (nowEnergy < maxEnergy)
            {
                nowEnergy++;
            }
            frame = 0;
        }
        /*if (frame == 60)
        {
            nowEnergy--;
            frame = 0; //This is Testcode
        }*/
    }
}