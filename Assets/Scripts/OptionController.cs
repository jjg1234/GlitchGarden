using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour {

	public Slider m_VolumeSlider,m_DifficultySlider;
	public LevelManager m_LevelManager;
	public Text m_VolumeTextValue,m_DifficultyTextValue;


	private enum DifficultyLevels { Easy,Normal,Hard,Nightmare }

	// Use this for initialization
	void Start () {
		m_LevelManager = GameObject.FindObjectOfType<LevelManager>();
		m_VolumeSlider.value = PlayerPrefManager.GetMasterVolume();
		m_DifficultySlider.value = PlayerPrefManager.GetDifficulty();
	}
	
	public void SaveAndExit()
	{
		PlayerPrefManager.SetMasterVolume(m_VolumeSlider.value);
		PlayerPrefManager.SetDifficulty(Mathf.CeilToInt(m_DifficultySlider.value));
		GameObject.FindObjectOfType<SoundManager>().GetComponent<AudioSource>().volume = m_VolumeSlider.value;
		m_LevelManager.LoadLevel("Menu");
	}

	// Update is called once per frame
	void Update () {
		m_VolumeTextValue.text = Mathf.CeilToInt(m_VolumeSlider.value*100) + "%";
		GameObject.FindObjectOfType<SoundManager>().GetComponent<AudioSource>().volume = m_VolumeSlider.value;
		m_DifficultyTextValue.text = (DifficultyLevels)m_DifficultySlider.value + "";
	}
}
