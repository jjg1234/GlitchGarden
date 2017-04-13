using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	public int m_Cost;
	private StarDisplay m_StarDisplay;

	private void Start()
	{
		m_StarDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}

	public void AddStars(int _amount)
	{
		m_StarDisplay.AddStars(_amount);
	}

	public int GetCost()
	{
		return m_Cost;
	}

	private void OnMouseDown()
	{
		if (Button.SellingSelected)
		{
			AddStars(m_Cost / 3);
			Destroy(gameObject);
		}
	}

}
