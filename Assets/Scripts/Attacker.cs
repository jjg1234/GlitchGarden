using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

	[Range (-1f,1.5f)]
	public float m_WalkSpeed;


	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("I, "+ gameObject.name +", collided with " + collision.gameObject.name + " in trigger mode" );
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * m_WalkSpeed * Time.deltaTime);
	}
}
