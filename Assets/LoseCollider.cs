using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private LevelManager m_LevelManager;
	
	private void Start()
	{
		m_LevelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<Attacker>())
		{
			m_LevelManager.LoadLevel("Lose");
		}
	}
}
