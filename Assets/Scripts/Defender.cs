using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	public float m_Life;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("I, " + gameObject.name + ", collided with " + collision.gameObject.name + " in trigger mode");
	}

	public void TakeDammage(float _damage)
	{
		m_Life -= _damage;
		if (GetComponent<Stone>())
		{
			gameObject.GetComponent<Animator>().SetTrigger("isDamaged"); ;
		}
		if (m_Life <=0)
		{
			Destroy(gameObject);
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
