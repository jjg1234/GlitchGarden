using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


	public float m_Speed;
	public float m_Damage;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * m_Speed * Time.deltaTime);
		transform.Rotate(Vector3.up * Time.deltaTime);

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<Attacker>())
		{
			collision.GetComponent<Attacker>().Damage(m_Damage);
			Destroy(gameObject);
		}
	}
}
