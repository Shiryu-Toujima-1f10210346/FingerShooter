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

	// Singleton�C���X�^���X���擾����
	public static SoundManager GetInstance()
	{
		return instance;
	}

	// �w�肳�ꂽ�N���b�v���Đ�����
	public void PlayClip(AudioClip clip)
	{
		audioSource.PlayOneShot(clip);
	}

	// �w�肳�ꂽ�N���b�v���Đ�����
	public static void Play(AudioClip clip)
	{
		GetInstance().PlayClip(clip);
	}
}