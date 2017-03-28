using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StarDisplay : MonoBehaviour
{

	Text m_Text;
	private int m_StarsAmount
	{
		get
		{
			return _StarsAmount;
		}
		set
		{
			_StarsAmount = value;
			m_Text.text = _StarsAmount.ToString();
		}
	}
	private int _StarsAmount;

	private void Start()
	{
		m_Text = GetComponent<Text>();
		m_StarsAmount = 500;
	}

	public void AddStars(int _amount)
	{
		m_StarsAmount += _amount;
		//m_Text.text = ""+m_StarsAmount;
	}

	public bool UseStars(int _amount)
	{
		if (m_StarsAmount - _amount >= 0)
		{
			m_StarsAmount -= _amount;
			//m_Text.text = "" + m_StarsAmount;
			return true;
		}
		return false;
	}
}
