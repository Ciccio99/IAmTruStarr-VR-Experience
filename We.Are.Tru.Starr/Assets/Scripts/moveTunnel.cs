using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTunnel : MonoBehaviour {
	public int rotationSpeed = 1;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
	}
}
