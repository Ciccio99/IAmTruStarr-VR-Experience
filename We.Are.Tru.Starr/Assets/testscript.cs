using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }


    void OnTriggerEnter(Collider col) {
        Debug.Log("I AM HERE");
        Debug.Log(col.gameObject.name);
    }

    void OnCollisionEnter(Collision col) {
        Debug.Log("I HUR INSTEAD");
        Debug.Log(col.gameObject.name);
    }
}
