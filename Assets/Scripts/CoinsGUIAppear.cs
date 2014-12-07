using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinsGUIAppear : MonoBehaviour {

	GameObject[] coinsPopUpObjects;
	GameObject coins;
	int score;
	Image scoreImage;

	// Use this for initialization
	void Start () {
		coinsPopUpObjects = GameObject.FindGameObjectsWithTag ("CoinsPopUp");
		setCoinsPopUpActive(false);

		//scoreImage = (Image)GameObject.FindGameObjectWithTag ("CoinsPopUp");

		coins = GameObject.FindGameObjectWithTag ("Coins");
		score = 0;
		
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
		//scoreImage.renderer.enabled = false;
		foreach(GameObject coinsPopUpObject in coinsPopUpObjects) {
			coinsPopUpObject.SetActive(active);
		}
	}

//	void animateScoreNotification (int points, Image scoreImage) {
//		score = score + points;
//		Vector3 imageLocation = scoreImage.transform.position;
//		imageLocation.x = imageLocation.x / Screen.width;
//		imageLocation.y = imageLocation.y / Screen.height;
//	
//		scoreImage.CrossFadeAlpha(0, 5, false);		
//	}
		
}

