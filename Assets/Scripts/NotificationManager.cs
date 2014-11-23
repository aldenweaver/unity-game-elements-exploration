using UnityEngine;
using System.Collections;

public class NotificationManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		// If object is coins, show notification
		if (other.gameObject.tag == "Coins") {

			other.gameObject.SetActive(false);
		}
		
		// If object is horse, show dialoue box
		if (other.gameObject.tag == "Horse") {

		}
		
		
	}
}
