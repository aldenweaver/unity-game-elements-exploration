// Modified from:
// http://answers.unity3d.com/questions/122479/attack-damage-scrolling.html#answer-122539

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FloatNotification : MonoBehaviour {

	public Color textColor = new Color(1f,50.5f, 69f);
	public float scroll = 0.05f;  // scrolling velocity
	public float duration = 1.5f; // time to disappear
	public float alpha;
	
	void Start(){
		guiText.material.color = textColor; // set text color
		alpha = 1;
	}
	
	void Update(){
		if (alpha>0){
			transform.position.y += scroll*Time.deltaTime; 
			alpha -= Time.deltaTime/duration; 
			guiText.material.GetColor(textColor).a = alpha;        
		} else {
			Destroy(gameObject); // text vanished - destroy itself
		}
	}
	
}
