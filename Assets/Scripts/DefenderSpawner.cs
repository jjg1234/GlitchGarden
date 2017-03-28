using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	private GameObject m_DefenderParents;
	private Camera m_MainCamera;
	private StarDisplay m_StarDisplay;
	// Use this for initialization
	void Start () {
		m_MainCamera = GameObject.FindObjectOfType<Camera>();
		m_StarDisplay = GameObject.FindObjectOfType<StarDisplay>();
		m_DefenderParents = GameObject.Find("Defenders");

		if (!m_DefenderParents)
		{
			m_DefenderParents = new GameObject("Defenders");
		}
	}	

	private void OnMouseDown()
	{
		Vector2 ClickPositionInWorldUnit = CalculateWorldPointFromClickPosition();

		if (Button.s_SelectedDefender)
		{
			if (m_StarDisplay.UseStars(Button.s_SelectedDefender.GetComponent<Defender>().GetCost()))
			{
				GameObject defender = Instantiate(Button.s_SelectedDefender, SnapToGrid(ClickPositionInWorldUnit), new Quaternion());
				defender.transform.parent = m_DefenderParents.transform;
			}
		}
	}

	Vector2 SnapToGrid(Vector2 _rawWorldPos)
	{
		return new Vector2(Mathf.Round(_rawWorldPos.x) ,Mathf.Round(_rawWorldPos.y));
	}

	Vector2 CalculateWorldPointFromClickPosition()
	{
		Vector3 myClickPosition3D = m_MainCamera.ScreenToWorldPoint(Input.mousePosition);
		return new Vector2(myClickPosition3D.x, myClickPosition3D.y);
	}
}
