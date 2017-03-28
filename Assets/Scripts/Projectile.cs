using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	/// <summary>
	/// Speed of the projectile in x axis to tweek
	/// </summary>
	[Tooltip("Movement speed to tweek projectile movement")]
	[Range(0f, 10f)]
	public float m_Speed;

	[Tooltip("To tweek Damage deal by the projectile")]
	[Range(0f, 1000f)]
	public float m_Damage;

	/// <summary>
	/// Update is called once per frame
	///Move our projectile (rotation by animator) 
	/// </summary>
	void Update () {
		transform.Translate(Vector3.right * m_Speed * Time.deltaTime);
		transform.Rotate(Vector3.up * Time.deltaTime);

	}

	/// <summary>
	/// Handle Collision
	/// </summary>
	/// <param name="collision">Collider2D object</param>
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<Attacker>())
		{
			collision.GetComponent<Health>().TakeDamage(m_Damage);
			Destroy(gameObject);
		}
	}


}
