using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public  GameObject m_ProjectileParent;
	public GameObject m_Projectile ;

	private void Start()
	{
		m_ProjectileParent = GameObject.Find("Projectiles");

		if (!m_ProjectileParent)
		{
			m_ProjectileParent = new GameObject("Projectiles");
		}
	}

	private void Fire()
	{
		GameObject projectile = Instantiate(m_Projectile,transform.FindChild("Gun").transform.position,new Quaternion());
		projectile.transform.parent = m_ProjectileParent.transform;
	}

}
