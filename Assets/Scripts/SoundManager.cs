using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour {

	public AudioClip[] m_LevelMusicArray;
	private AudioSource p_AudioSource;
	const int OPTION_LEVEL = 2;

	private void OnEnable()
	{
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}

	private void OnDisable()
	{
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}

	private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)//int level)
	{
		if (scene.buildIndex != OPTION_LEVEL)
		{
			p_AudioSource.clip = m_LevelMusicArray[scene.buildIndex];
			p_AudioSource.loop = true;
			p_AudioSource.Play();
		}
		
	}

	private void Awake()
	{
		p_AudioSource = GetComponent<AudioSource>() as AudioSource;
		GameObject.DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<AudioSource>().volume = PlayerPrefManager.GetMasterVolume();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
