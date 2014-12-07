using UnityEngine;
using System.Collections;

public class CoinsGUIAppear : MonoBehaviour {

	GameObject[] coinsPopUpObjects;
	GameObject coins;
	
	// Use this for initialization
	void Start () {
		coinsPopUpObjects = GameObject.FindGameObjectsWithTag ("CoinsPopUp");
		setCoinsPopUpActive(false);

		coins = GameObject.FindGameObjectWithTag ("Coins");
		
		Debug.Log ("Initialization of CoinsGUIAppear complete.");
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
			coins.SetActive(false);
		}
	}
	
	void setCoinsPopUpActive (bool active) {
		foreach(GameObject coinsPopUpObject in coinsPopUpObjects) {
			coinsPopUpObject.SetActive(active);
		}
	}
		
		
}

