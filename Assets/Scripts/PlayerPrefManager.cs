using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefManager : MonoBehaviour
{

	const string MASTER_VOLUME_KEY = "MASTER_VOLUME";
	const string DIFFICULTY_KEY = "DIFFICULTY";
	//const string LEVEL_KEY = "LEVEL"; no use for now 

	public static void SetMasterVolume(float _volume)
	{
		PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, Mathf.Clamp(_volume, 0f, 1f));
	}

	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}

	public static void SetDifficulty(int _difficulty)
	{
		PlayerPrefs.SetInt(DIFFICULTY_KEY, Mathf.Clamp(_difficulty, 0, 4));
	}

	public static int GetDifficulty()
	{
		return PlayerPrefs.GetInt(DIFFICULTY_KEY);
	}
}
