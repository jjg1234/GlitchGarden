using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

	public GameObject m_ProjectileParent;
	public GameObject m_Projectile;
	private Animator m_Animator;

	private void Start()
	{
		m_Animator = GetComponent<Animator>();
		m_ProjectileParent = GameObject.Find("Projectiles");

		if (!m_ProjectileParent)
		{
			m_ProjectileParent = new GameObject("Projectiles");
		}
	}

	private void Update()
	{
		if (IsAttackerAheadInLane())
		{
			m_Animator.SetBool("EnemyInSight", true);
		}
		else
		{
			m_Animator.SetBool("EnemyInSight", false);
		}
	}

	private bool IsAttackerAheadInLane()
	{
		//RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right),Mathf.Infinity, LayerMask.NameToLayer("Attackers"));

		//if (hit.collider != null)
		//{
		//	if (hit.collider.tag == "Attackers")
		//	{
		//		Debug.Log("Raycast found " + hit.collider.name);
		//		//Can be usefull if the shooter have a maximum range
		//		float distance = Mathf.Abs(hit.point.x - transform.position.x);


		//		return true;

		//	}
			
			

		//}

		//return false;


		
		RaycastHit2D hit01 = Physics2D.Raycast(transform.position, new Vector2(1,0), Mathf.Infinity);


		//------------------------------------------------
		Vector2 direction = transform.TransformDirection(Vector2.right);
		RaycastHit2D[] hit = Physics2D.RaycastAll(transform.position, direction, 10 - Mathf.Ceil(transform.position.x));

		if (hit01.transform != null)
		{
			foreach (RaycastHit2D gameObjectHit in hit)
			{
				if (gameObjectHit.transform.tag == "Attackers")
				{
					
					return true;
				}
			}
		}
		return false;
	}

	private void Fire()
	{
		GameObject projectile = Instantiate(m_Projectile, transform.FindChild("Gun").transform.position, new Quaternion());
		projectile.transform.parent = m_ProjectileParent.transform;
	}

}
