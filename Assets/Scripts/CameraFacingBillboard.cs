// Source: http://wiki.unity3d.com/index.php?title=CameraFacingBillboard

using UnityEngine;
using System.Collections;

public class CameraFacingBillboard : MonoBehaviour
{
	public Camera m_Camera;
	
	void Update()
	{
		transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.back,
		                 m_Camera.transform.rotation * Vector3.up);
	}
}