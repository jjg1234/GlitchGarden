using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
	[Tooltip("Movement speed to tweek the animation")]
	[Range(-1f, 1.5f)]
	public float m_WalkSpeed;
	[Tooltip("Average number seconds between to spawns")]
	public float m_SeenEverySeconds;

	private GameObject m_Target;

	// Use this for initialization
	void Start()
	{

	}

	public void SetTarget(GameObject _target)
	{
		m_Target = _target;
	}

	public void SetSpeed(float _speed)
	{
		m_WalkSpeed = _speed;
	}

	public void StrikeCurrentTarget(float _damage)
	{
		if (
			m_Target != null)
		{
			//Debug.Log("I, " + gameObject.name + ", attack " + m_Target.name + " and deal him  " + _damage + " damage");
			m_Target.GetComponent<Health>().TakeDamage(_damage);
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
