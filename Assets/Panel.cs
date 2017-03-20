using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Image>().CrossFadeAlpha(0, 3, true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
