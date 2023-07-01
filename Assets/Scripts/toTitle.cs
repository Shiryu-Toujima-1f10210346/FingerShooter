using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toTitle : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnClick()
    {
        Debug.Log("Back to Title");
        SceneManager.LoadScene("title");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
