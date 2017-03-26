using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public static GameObject s_SelectedDefender;
	public GameObject DefenderPrefab;
	bool m_IsSelected;

	// Use this for initialization
	void Start () {
		setColor(Color.gray);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{

		if (m_IsSelected)
		{
			foreach (var item in FindObjectsOfType<Button>())
			{
				item.Deselect();
				s_SelectedDefender = null;
			}
		}
		else
		{
			foreach (var item in FindObjectsOfType<Button>())
			{
				item.Deselect();
			}

			s_SelectedDefender = DefenderPrefab;
			m_IsSelected = true;
			//Debug.Log("button " + name);
			GetComponent<SpriteRenderer>().color = Color.white;
		}
		
	}

	public void Deselect()
	{
		m_IsSelected = false;
		setColor(Color.gray);
	}

	public void setColor(Color _color)
	{
		GetComponent<SpriteRenderer>().color = _color;

	}

	private void OnMouseEnter()
	{
		if (!m_IsSelected)
		{
			setColor(Color.yellow);
		}
		
	}

	private void OnMouseExit()
	{
		if (!m_IsSelected)
		{
			setColor(Color.gray);
		}
	}
}
