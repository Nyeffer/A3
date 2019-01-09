using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamePosition : MonoBehaviour {

	public GameObject host; // GameObject that this object copies the position of
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = host.transform.position;
	}
}
