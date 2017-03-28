using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Defender))]
public class Shooter : MonoBehaviour
{
	[Tooltip("Prefab of the Projectile that the Shooter will launch.")]
	public GameObject m_Projectile;

	private Animator m_Animator;
	private GameObject m_ProjectileParent;

	/// <summary>
	/// Initialisation :
	/// Taking Animator and Instanciate Parent if do not exists
	/// </summary>
	private void Start()
	{
		//Initialize Animator
		m_Animator = GetComponent<Animator>();

		//Initialize Parent
		m_ProjectileParent = GameObject.Find("Projectiles");

		if (!m_ProjectileParent)
		{
			m_ProjectileParent = new GameObject("Projectiles");
		}
	}

	/// <summary>
	/// Called every frame
	/// Check if Attacker in sight and set animator to Attack state
	/// </summary>
	private void Update()
	{
		//Activate attack mode if an enemy is in sight
		m_Animator.SetBool("EnemyInSight", IsAttackerAheadInLane());
	}

	/// <summary>
	/// Check if an Attaker is at the right of the Shooter
	/// </summary>
	/// <returns>true if there is an Attacker at the right of the Shooter</returns>
	private bool IsAttackerAheadInLane()
	{
		//Set direction to x>0
		Vector2 direction = transform.TransformDirection(Vector2.right);

		//Get all Hits into an array
		RaycastHit2D[] hit = Physics2D.RaycastAll(transform.position, direction, 10 - Mathf.Ceil(transform.position.x));

		//If there is at leat one hit
		if (hit != null)
		{
			//Search trhough all hits
			foreach (RaycastHit2D gameObjectHit in hit)
			{
				//If it's an Attacker
				if (gameObjectHit.transform.tag == "Attackers")
				{
					//The we have an attaker ahead in line
					return true;
				}
			}
		}
		//No Attacker found
		return false;
	}

	/// <summary>
	/// Fire an instance of the projectile Prefab
	/// </summary>
	private void Fire()
	{
		//Instanciate a projectile from Prefab
		GameObject projectile = Instantiate(m_Projectile, transform.FindChild("Gun").transform.position, new Quaternion());
		//Set the Projectile parent for readability
		projectile.transform.parent = m_ProjectileParent.transform;
	}

}
