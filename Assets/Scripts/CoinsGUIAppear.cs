using UnityEngine;
using System.Collections;

public class CoinsGUIAppear : MonoBehaviour {

	GameObject[] coinsPopUpObjects;
	
	// Use this for initialization
	void Start () {
		coinsPopUpObjects = GameObject.FindGameObjectsWithTag ("CoinsPopUp");
		setCoinsPopUpActive(false);
		
		Debug.Log ("Initialization of GUIAppear complete.");
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerStay (Collider collided) {
		if(collided.tag == "Player") {
			setCoinsPopUpActive(true);
		}
	}
	
	void OnTriggerExit (Collider collided) {
		if(collided.tag == "Player") {
			setCoinsPopUpActive(false);
		}
	}
	
	void setCoinsPopUpActive (bool active) {
		foreach(GameObject coinsPopUpObject in coinsPopUpObjects) {
			coinsPopUpObject.SetActive(active);
		}
	}
		
		
}

