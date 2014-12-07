using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingImage : MonoBehaviour {
	
	public float scroll = 0.05f;  // scrolling velocity
	public float duration = 1.5f; // time to disappear
	public float alpha;
	
	void Start(){

		alpha = 1;
	}
	
	void Update(){
		if (alpha > 0){
			float yPos = transform.position.y;
			yPos = transform.position.y + scroll*Time.deltaTime; 
			alpha -= Time.deltaTime/duration;       
		} else {
			Destroy(gameObject); // text vanished - destroy itself
		}
	}
}
