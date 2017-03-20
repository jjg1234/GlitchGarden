using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour {

	public AudioClip[] m_LevelMusicArray;
	private AudioSource p_AudioSource;

	private void OnLevelWasLoaded(int level)
	{	
		p_AudioSource.clip = m_LevelMusicArray[level];
		p_AudioSource.loop = true;
		p_AudioSource.Play();
	}

	private void Awake()
	{
		p_AudioSource = GetComponent<AudioSource>() as AudioSource;
		GameObject.DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
