using UnityEngine;
using System.Collections;

public class GUIAppear : MonoBehaviour {
	
	private bool guiShow = false;
	GameObject[] horsePopUpObjects;
	Component[] horsePopUpObjects2;

	// Use this for initialization
	void Start () {
		//guiShow = false;
		horsePopUpObjects = GameObject.FindGameObjectsWithTag ("HorsePopUp");
		foreach(GameObject horsePopUpObject in horsePopUpObjects) {
			horsePopUpObject.SetActive(false);
		}
		//horsePopUpObjects2 = GetComponents ("HorsePopUp");
		OnGUI ();

		Debug.Log ("Initialization of GUIAppear complete.");
	}
	
	// Update is called once per frame
	void Update () {
		OnGUI ();
	}
	
	void OnTriggerStay (Collider collided) {
		if(collided.tag == "Player") {
			foreach(GameObject horsePopUpObject in horsePopUpObjects) {
				horsePopUpObject.SetActive(true);
			}
		}
	}
	
	void OnTriggerExit (Collider collided) {
		if(collided.tag == "Player") {
			foreach(GameObject horsePopUpObject in horsePopUpObjects) {
				horsePopUpObject.SetActive(false);
			}
		}
	}
	
	void OnGUI () {
//		if(guiShow = true) {
//			foreach(GameObject horsePopUpObject in horsePopUpObjects) {
//				horsePopUpObject.SetActive(true);
//			}
//
////			foreach(Component horsePopUpObject2 in horsePopUpObjects2) {
////				horsePopUpObject2.renderer.enabled = true;
////			}
//		}
//
//		if(guiShow = false) {
//			foreach(GameObject horsePopUpObject in horsePopUpObjects) {
//				horsePopUpObject.SetActive(false);
//			}
//
////			foreach(Component horsePopUpObject2 in horsePopUpObjects2) {
////				horsePopUpObject2.renderer.enabled = false;
////			}
//		}
	}

}
