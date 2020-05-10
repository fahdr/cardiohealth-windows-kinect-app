using UnityEngine;
using System.Collections;

[RequireComponent (typeof (GameObject))]
public class EntryDetails : MonoBehaviour {
	
	// used for workout entry selection

	public int CubeNumber = 0;


	void OnMouseEnter() {
		GetComponent<Renderer>().material.color = Color.red;
		Camera.main.transform.SendMessage ("DetailsDisplay", CubeNumber);
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = Color.white;
	}
}
