﻿using UnityEngine;
using System.Collections;

public class LogoutButton : MonoBehaviour {


	private Color col;

	void Start () {
		// Default Colour is saved
		col = GetComponent<Renderer>().material.color;
	}
	

	void OnMouseEnter() {
		// Colour changed to darker colour to simulate pushed in effect
		GetComponent<Renderer>().material.color = new Color32(15, 71, 59, 255);;

	}

	void OnMouseExit() {
		//On exit returns to normal
		GetComponent<Renderer>().material.color = col;
	}


	void OnMouseDown() {
		// On logout delete all currently saved preference within game, such as current user
		PlayerPrefs.DeleteAll();
		Application.LoadLevel ("LoginScene");
	}


}