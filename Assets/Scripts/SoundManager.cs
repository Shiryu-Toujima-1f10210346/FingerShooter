using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour
{
	private static SoundManager instance;
	private AudioSource audioSource;

	// Use this for initialization
	void Awake()
	{
		instance = this;
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	// Singletonインスタンスを取得する
	public static SoundManager GetInstance()
	{
		return instance;
	}

	// 指定されたクリップを再生する
	public void PlayClip(AudioClip clip)
	{
		audioSource.PlayOneShot(clip);
	}

	// 指定されたクリップを再生する
	public static void Play(AudioClip clip)
	{
		GetInstance().PlayClip(clip);
	}
}