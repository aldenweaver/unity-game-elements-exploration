using UnityEngine;
using System.Collections;

// Can abstract this to an interface
public class HorseGUIAppear : MonoBehaviour {

	GameObject[] horsePopUpObjects;

	// Use this for initialization
	void Start () {
		horsePopUpObjects = GameObject.FindGameObjectsWithTag ("HorsePopUp");
		setHorsePopUpActive(false);

		Debug.Log ("Initialization of HorseGUIAppear complete.");
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerStay (Collider collided) {
		if(collided.tag == "Player") {
			setHorsePopUpActive(true);
		}
	}
	
	void OnTriggerExit (Collider collided) {
		if(collided.tag == "Player") {
			setHorsePopUpActive(false);
		}
	}

	void setHorsePopUpActive (bool active) {
		foreach(GameObject horsePopUpObject in horsePopUpObjects) {
			horsePopUpObject.SetActive(active);
		}
	}


}
