using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toShop : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnClick()
    {
        Debug.Log("Move to Shop");
        SceneManager.LoadScene("Shop");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
