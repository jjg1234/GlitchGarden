using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	private GameObject m_DefenderParents;

	// Use this for initialization
	void Start () {
		m_DefenderParents = GameObject.Find("Defenders");

		if (!m_DefenderParents)
		{
			m_DefenderParents = new GameObject("Defenders");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		Vector2 ClickPositionInWorldUnit = CalculateWorldPointFromClickPosition();
		//Debug.Log(ClickPositionInWorldUnit);
		//Debug.Log(SnapToGrid(ClickPositionInWorldUnit));


		if (Button.s_SelectedDefender)
		{
			GameObject defender =  Instantiate(Button.s_SelectedDefender, SnapToGrid(ClickPositionInWorldUnit), new Quaternion());
			defender.transform.parent = m_DefenderParents.transform;
		}
	}

	Vector2 SnapToGrid(Vector2 _rawWorldPos)
	{
		return new Vector2(Mathf.Round(_rawWorldPos.x) ,Mathf.Round(_rawWorldPos.y));
	}

	Vector2 CalculateWorldPointFromClickPosition()
	{
		Vector3 myClickPosition3D = GameObject.FindObjectOfType<Camera>().ScreenToWorldPoint(Input.mousePosition);
		return new Vector2(myClickPosition3D.x, myClickPosition3D.y);

	}
}
