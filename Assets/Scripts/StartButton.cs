using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Threading.Tasks;
public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip sound1;
    AudioSource audioSource;

    public void OnClick()
    {
        Debug.Log("Start");
        //audioSource.PlayOneShot(sound1);
        //await Task.Delay(600);
        SceneManager.LoadScene("main");
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
