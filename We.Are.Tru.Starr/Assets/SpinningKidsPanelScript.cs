using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningKidsPanelScript : MonoBehaviour {

    public float rotationSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0f, -rotationSpeed, 0f));
	}
}
