using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Defender))]
public class Gnome : MonoBehaviour
{
	public GameObject m_Projectile;

	// Use this for initialization
	void Start()
	{

	}

	public void ShootAxe()
	{
		Instantiate(m_Projectile, transform);
	}
}
