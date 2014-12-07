using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerGUIAppear : MonoBehaviour {
	
	GameObject[] powerPopUpObjects;
	GameObject powerPole;
	
	// Use this for initialization
	void Start () {
		powerPopUpObjects = GameObject.FindGameObjectsWithTag ("PowerPopUp");
		setPowerPopUpActive(false);

		powerPole = GameObject.FindGameObjectWithTag ("PowerPole");
		
		Debug.Log ("Initialization of CoinsGUIAppear complete.");
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerStay (Collider collided) {
		if(collided.tag == "Player") {
			setPowerPopUpActive(true);
		}
	}
	
	void OnTriggerExit (Collider collided) {
//		if(collided.tag == "Player") {
//			setPowerPopUpActive(false);
//			powerPole.SetActive(false);
//		}
	}
	
	void setPowerPopUpActive (bool active) {
		foreach(GameObject powerPopUpObject in powerPopUpObjects) {
			powerPopUpObject.SetActive(active);
		}
	}
	

}

