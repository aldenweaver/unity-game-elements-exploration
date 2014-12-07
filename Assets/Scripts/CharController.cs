using UnityEngine;
using System.Collections;
using UnityEditor;

[RequireComponent (typeof(CharacterController))]
public class CharController : MonoBehaviour {
	CharacterController characterController;
	public float movementSpeed = 5.0f;
	public float mouseSensitivity = 5.0f;
	//GameObject[] envObjects;
	object coinsLogText = "Collided with Coins";
	object horseLogText = "Collided with Horse";
	
	float verticalVelocity = 0;
	float verticalRotation = 0;
	public float updownRange = 60.0f;
	float jumpSpeed = 7;

	GameObject[] horsePopUpObjects;


//	public Transform ptsPrefab = GameObject.FindGameObjectWithTag("Coins"); // drag the prefab to this variable in Inspector
//	
//	void SpawnPts(float points, float x, float y){
//		x = Mathf.Clamp(x,0.05,0.95); // clamp position to screen to ensure
//		y = Mathf.Clamp(y,0.05,0.9);  // the string will be visible
//		Transform gui = Instantiate(ptsPrefab,Vector3(x,y,0),Quaternion.identity);
//		gui.guiText.text = points.ToString();
//	}
//	
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		characterController = GetComponent<CharacterController> ();
		horsePopUpObjects = GameObject.FindGameObjectsWithTag ("HorsePopUp");
		foreach (GameObject horsePopUpObject in horsePopUpObjects) {
			horsePopUpObject.renderer.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		// Rotation to view scene
		float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotLeftRight, 0);
		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -updownRange, updownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);
		
		// Spacebar control
		if (Input.GetButtonDown ("Jump")) {
			//verticalVelocity = jumpSpeed; // code to jump
		}

		// Movement control using directional keys
		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;
				
		verticalVelocity += Physics.gravity.y * Time.deltaTime;
		Vector3 speed = new Vector3 (sideSpeed, verticalVelocity, forwardSpeed);
		speed = transform.rotation * speed;
		characterController.Move (speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		Vector3 v = Camera.main.WorldToViewportPoint(transform.position);

		// If object is coins, show notification
		if (other.gameObject.tag == "Coins") {
			Debug.Log(coinsLogText);
			//SpawnPts(4200, v.x, v.y);
			other.gameObject.SetActive(false);
		}
		
		// If object is horse, show dialoue box
		if (other.gameObject.tag == "Horse") {
			foreach (GameObject horsePopUpObject in horsePopUpObjects) {
				horsePopUpObject.renderer.enabled = true;
			}

			EditorUtility.DisplayDialog ("Horseback Ride",
			                             "Would you like to ride this horse?", "Yes", "No"); 
			Debug.Log(horseLogText);
		}
	}
	
//[MenuItem ("Example/Place Selection On Surface")]
//	static void createActionBox() {
//	Transform[] transforms = Selection.GetTransforms(SelectionMode.Deep |
//		                                                 SelectionMode.ExcludePrefab | SelectionMode.Editable);
//		EditorUtility.DisplayDialog ("Horseback Ride",
//		                            "Would you like to ride this horse?", "Yes", "No"); 
//			foreach (Transform transform in transforms) {
//				RaycastHit hit;
//				if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
//					transform.position = hit.point;
//					Vector3 randomized = Random.onUnitSphere;
//					randomized = new Vector3(randomized.x, 0F, randomized.z);
//					transform.rotation = Quaternion.LookRotation(randomized, hit.normal);
//				}
//			}
//
//	}
}
