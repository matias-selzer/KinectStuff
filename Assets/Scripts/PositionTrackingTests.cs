using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class PositionTrackingTests : MonoBehaviour {

	public float multiplier;
	public Transform recinto;

	// Use this for initialization
	void Start () {
		UnityEngine.XR.InputTracking.disablePositionalTracking = true;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = UnityEngine.XR.InputTracking.GetLocalPosition (UnityEngine.XR.XRNode.Head);
		Vector3 rot = UnityEngine.XR.InputTracking.GetLocalRotation (UnityEngine.XR.XRNode.Head).eulerAngles;

		//Debug.Log ("position "+pos);
		Debug.Log (rot);

		pos = new Vector3(pos.x*multiplier,pos.y+1.7f,pos.z*multiplier);
		//rot = rot * 2;

		rot.x = 0;
		rot.z = 0;

		transform.position = pos;

		/*
		Vector3 oldPos = recinto.position;
		recinto.position = transform.position;
		recinto.rotation = Quaternion.Euler (rot*-1);
		recinto.position = oldPos;

*/



	}
}
