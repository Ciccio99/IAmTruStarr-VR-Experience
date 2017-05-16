using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinkingTextScript : MonoBehaviour {

    Renderer renderer;

    void Start() {
        renderer = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!IsInvoking("toggle"))
            Invoke("toggle", 1f);
	}

    private void toggle() {
        if (renderer.enabled)
            renderer.enabled = false;
        else
            renderer.enabled = true;
    }
}
