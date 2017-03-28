using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer))]
public class Button : MonoBehaviour
{

	/// <summary>
	/// Store the defender prefab linked to the selected button
	/// </summary>
	public static GameObject s_SelectedDefender;

	/// <summary>
	/// Prefab of the defender this button instanciate
	/// </summary>
	[Tooltip("Put here the Prefab of the Defender to instanciate if this button is selected")]
	public GameObject m_DefenderPrefab;

	/// <summary>
	/// State of selection of the button
	/// </summary>
	private bool m_IsSelected;

	/// <summary>
	/// Sprite renderer to handle color
	/// </summary>
	private SpriteRenderer m_MySpriteRenderer;

	/// <summary>
	/// List of all Buttons
	/// </summary>
	private Button[] m_AllButtonArray;

	private Text m_Cost;

	// Use this for initialization
	private void Start()
	{
		m_AllButtonArray = FindObjectsOfType<Button>();
		m_MySpriteRenderer = GetComponent<SpriteRenderer>();
		setColor(Color.gray);
		m_Cost = GetComponentInChildren<Text>();
		m_Cost.text = m_DefenderPrefab.GetComponent<Defender>().GetCost().ToString();
	}

	private void OnMouseDown()
	{
		DeselectAll();

		if (!m_IsSelected)
		{
			s_SelectedDefender = m_DefenderPrefab;
			m_IsSelected = true;
			m_MySpriteRenderer.color = Color.white;
		}

	}

	public void DeselectAll()
	{
		foreach (var item in m_AllButtonArray)
		{
			item.m_IsSelected = false;
			item.setColor(Color.gray);
		}
		s_SelectedDefender = null;
	}

	private void setColor(Color _color)
	{
		m_MySpriteRenderer.color = _color;
	}


	//Code uniquement pour la version PC/Linus/Mac
# if UNITY_STANDALONE
	/// <summary>
	/// Useless for mobile version
	/// </summary>

	private void OnMouseEnter()
	{
		if (!m_IsSelected)
		{
			setColor(Color.yellow);
		}
	}

	/// <summary>
	/// Useless for mobile version
	/// </summary>
	private void OnMouseExit()
	{
		if (!m_IsSelected)
		{
			setColor(Color.gray);
		}
	}
#endif
}
