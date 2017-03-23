using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Attacker
{

	public void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("I, " + gameObject.name + ", collided with " + collision.gameObject.name + " in trigger mode");
		

		if (collision.gameObject.GetComponent<Stone>())
		{
			Debug.Log("I Jump");
			GetComponent<Animator>().SetTrigger("Jump");
		}
		else
		{
			//if (collision.gameObject.tag == "Defender")
			//{
			//	GetComponent<Animator>().SetBool("isAttacking", true);
			//}

			if (collision.gameObject.GetComponent<Defender>())
			{
				base.m_Target = collision.gameObject;
				GetComponent<Animator>().SetBool("isAttacking", true);
			}

		}

	}

}
