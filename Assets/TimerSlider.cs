using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSlider : MonoBehaviour
{
	private LevelManager m_LevelManager;
	private Slider m_TimerSlider;
	public float m_SurvivedTimeToWin = 120;

	// Use this for initialization
	void Start()
	{
		m_LevelManager = GameObject.FindObjectOfType<LevelManager>();
		m_TimerSlider = GetComponent<Slider>();
	}

	// Update is called once per frame
	void Update()
	{

		m_TimerSlider.value = Time.timeSinceLevelLoad / m_SurvivedTimeToWin;
		if (m_TimerSlider.value >= 1)
		{
			//Play tune and load next Level
			m_LevelManager.LoadNextLevel();
		}
	}
}
