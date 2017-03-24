using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public GameObject m_Projectile, m_ProjectileParent;

	private void Fire()
	{
		GameObject projectile = Instantiate(m_Projectile,transform.FindChild("Gun").transform.position,new Quaternion());
		projectile.transform.parent = m_ProjectileParent.transform;
	}

}
