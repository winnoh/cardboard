using UnityEngine;
using System.Collections;

public class PhoneSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseOver (GameObject gameObject) {
		// Show mouse over UI element (unhide?)
		gameObject.SetActive(true);
	}

	public void OnMouseExit (GameObject gameObject) { 
		// Undo Mouseover
		gameObject.SetActive(false);
	}

	public void OnMouseClick (GameObject gameObject) {
		
	}
}

