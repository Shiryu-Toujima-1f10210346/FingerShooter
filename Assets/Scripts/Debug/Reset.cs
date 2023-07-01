using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reset : MonoBehaviour
{
    public AudioClip clip;
    public void Onclick()
    {
        GameObject.FindObjectOfType<AudioSource>().PlayOneShot(clip);
        Time.timeScale = 1f;
        SceneManager.LoadScene("main");
    }
}
