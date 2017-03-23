using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

	[Range(-1f, 1.5f)]
	public float m_WalkSpeed;

	public GameObject m_Target;

	// Use this for initialization
	void Start()
	{

	}

	//public void OnTriggerEnter2D(Collider2D collision)
	//{
	//	Debug.Log("I, " + gameObject.name + ", collided with " + collision.gameObject.name + " in trigger mode");
	//	m_Target = collision.gameObject;

	//	if (collision.gameObject.tag == "Defender")
	//	{
	//		GetComponent<Animator>().SetBool("isAttacking", true);
	//	}
	//}

	public void SetSpeed(float _speed)
	{
		m_WalkSpeed = _speed;
	}

	public void StrikeCurrentTarget(float _damage)
	{
		
		if (m_Target != null)
		{
			Debug.Log("I, " + gameObject.name + ", attack " + m_Target.name + " and deal him  " + _damage + " damage");

			if (m_Target.GetComponent<Defender>())
			{
				m_Target.GetComponent<Defender>().TakeDammage(_damage);
			}
		}
		else
		{
			GetComponent<Animator>().SetBool("isAttacking", false);
		}
		
	}


	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector3.left * m_WalkSpeed * Time.deltaTime);
	}
}
