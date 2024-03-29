﻿using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	// Back Button class to be used by each Screen off Main Menu
	// this script must be attacted to a gameobject to be used as a button

	private Color col;

	void Start () {
		// Default Colour is saved
		col  = GetComponent<Renderer>().material.color;
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
		// Loads Main menu scene
		Application.LoadLevel ("MenuScene");
	}
}
