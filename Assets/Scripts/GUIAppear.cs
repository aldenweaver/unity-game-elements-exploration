using UnityEngine;
using System.Collections;

public class GUIAppear : MonoBehaviour {
	
	private bool guiShow = false;
	GameObject[] horsePopUpObjects;

	// Use this for initialization
	void Start () {
		guiShow = false;
		horsePopUpObjects = GameObject.FindGameObjectsWithTag ("HorsePopUp");
		Debug.Log ("Initialization of GUIAppear complete.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerStay (Collider collided) {
		if(collided.tag == "Player") {
			guiShow = true;
		}
	}
	
	void OnTriggerExit (Collider collided) {
		if(collided.tag == "Player") {
			guiShow = false;
		}
	}
	
	void OnGUI () {
		if(guiShow = true) {
			foreach(GameObject horsePopUpObject in horsePopUpObjects) {
				horsePopUpObject.SetActive(true);
			}
		}

		if(guiShow = false) {
			foreach(GameObject horsePopUpObject in horsePopUpObjects) {
				horsePopUpObject.SetActive(false);
			}
		}
	}

}
