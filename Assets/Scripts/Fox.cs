using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Fox : MonoBehaviour
{

	private Animator m_Animator;
	private Attacker m_Attacker;

	private void Start()
	{
		m_Animator = GetComponent<Animator>();
		m_Attacker = GetComponent<Attacker>();
	}


	public void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("I, " + gameObject.name + ", collided with " + collision.gameObject.name + " in trigger mode");


		if (collision.gameObject.GetComponent<Defender>())
		{
			if (collision.gameObject.GetComponent<Stone>())
			{
				Debug.Log("I Jump");
				m_Animator.SetTrigger("Jump");
			}
			else
			{
				m_Attacker.m_Target = collision.gameObject;
				m_Animator.SetBool("isAttacking", true);
			}

		}

	}

}
