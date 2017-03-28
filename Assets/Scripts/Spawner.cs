using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] m_SpawnablesPrefabs;

	// Update is called once per frame
	void Update()
	{
		foreach (GameObject thisAttacker in m_SpawnablesPrefabs)
		{
			if (isTimeToSpawn(thisAttacker))
			{
				Spawn(thisAttacker);
			}
		}
	}

	public void Spawn(GameObject _toSpawn)
	{
		GameObject newAttacker = Instantiate(_toSpawn,transform.position,new Quaternion());
		newAttacker.transform.parent = transform;
	}

	bool isTimeToSpawnJJG(GameObject _toSpawn)
	{
		float spawnRate = _toSpawn.GetComponent<Attacker>().m_SeenEverySeconds;
		return Time.timeSinceLevelLoad % spawnRate <= 0.01;
	}

	bool isTimeToSpawn(GameObject _toSpawn)
	{
		float spawnRate = _toSpawn.GetComponent<Attacker>().m_SeenEverySeconds;

		float spawnPerSec = 1 / spawnRate;

		if (Time.deltaTime > spawnRate)
		{
			Debug.LogWarning("Spawn Rate Capped by frame rate");
		}

		float Threshold = spawnPerSec * Time.deltaTime / 5; // /5 is because there is 5 Lanes

		return Random.value < Threshold;
	}
}

