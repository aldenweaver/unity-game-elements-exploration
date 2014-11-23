// Source: http://unitydojo.blogspot.com/2014/09/unity-46-simple-tutorial-health-bar-and.html

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateTempPopUp: MonoBehaviour {
	public Transform damageTransform;
	public GameObject damagePrefab;

	// The damage to show as a popup
	public void CreateTempPopup(int damage){
		GameObject damageGameObject = (GameObject)Instantiate(damagePrefab,
		                                                      damageTransform.position,
		                                                      damageTransform.rotation);
		//damageGameObject.GetComponentInChildren<text>().text = damage.ToString();
	}
}
