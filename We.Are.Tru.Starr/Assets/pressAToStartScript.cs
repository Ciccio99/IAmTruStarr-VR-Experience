using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressAToStartScript : MonoBehaviour {

    bool pressed;

    void Start() {
        pressed = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.One) && !pressed) {
            StartMusicExperience();
        }
	}

    private void StartMusicExperience() {
        SceneMusicFlowManger.instance.StartMusicFlow();
        Debug.Log("Started Music flow");
        pressed = true;
        Destroy(this);
    }


}
