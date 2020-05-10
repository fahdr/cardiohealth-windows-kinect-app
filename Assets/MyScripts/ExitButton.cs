using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {

	Color col;
	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		col  = GetComponent<Renderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseEnter() {
		GetComponent<Renderer>().material.color = new Color32(15, 71, 59, 255);;

	}
	
	
	
	
	void OnMouseExit() {
		GetComponent<Renderer>().material.color = col;

	}


	void OnMouseDown() {
		Application.Quit ();
	}

}
