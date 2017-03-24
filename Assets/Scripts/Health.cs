using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {


	public float m_Life;

	public void TakeDamage(float _damage)
	{
		m_Life -= _damage;
		if (GetComponent<Stone>())
		{
			gameObject.GetComponent<Animator>().SetTrigger("isDamaged"); ;
		}
		if (m_Life <= 0)
		{
			Destroy(gameObject);
		}
	}
}
