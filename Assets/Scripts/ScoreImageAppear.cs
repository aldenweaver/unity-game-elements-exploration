using UnityEngine;
using System.Collections;

public class ScoreImageAppear : MonoBehaviour {

	private bool guiShow = false;
	GameObject scorePopUp;
	
	// Use this for initialization
	void Start () {
		guiShow = false;
		scorePopUp = GameObject.FindGameObjectWithTag ("Score");
		Debug.Log ("Initialization of ScoreImageAppear complete.");
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
			scorePopUp.SetActive(true);
		}

		if(guiShow = false) {
			scorePopUp.SetActive(false);
		}
	}
}
