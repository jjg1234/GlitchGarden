using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	public float m_Life;

	public void TakeDammage(float _dammage)
	{
		m_Life -= _dammage;
		if (m_Life<=0)
		{
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("I, " + gameObject.name + ", collided with " + collision.gameObject.name + " in trigger mode");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
