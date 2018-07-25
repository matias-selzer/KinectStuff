using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTracking : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
		UnityEngine.XR.InputTracking.disablePositionalTracking = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position;
	}
}
