using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Defender))]
public class Cactus : MonoBehaviour {

	public GameObject m_Projectile;
	private Animator m_Animator;

	// Use this for initialization
	void Start()
	{
		m_Animator = GetComponent<Animator>();
	}

	private void Update()
	{
		
	}

	public void ShootAxe()
	{
		m_Animator.SetBool("EnemyIOnSigth", true);
		Instantiate(m_Projectile, transform);
	}

}
