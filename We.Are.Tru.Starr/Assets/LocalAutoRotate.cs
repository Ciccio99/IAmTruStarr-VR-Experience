using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalAutoRotate : MonoBehaviour {

    public float rotationSpeed = 1;

    private float rotationRate = 0.1f;
    private Transform trans;

    private void Awake()
    {
        trans = gameObject.transform;
    }
	
	// Update is called once per frame
	void Update () {
        trans.Rotate(new Vector3(0f, 0f, rotationRate * rotationSpeed));
	}
}
