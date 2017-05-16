using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkybox : MonoBehaviour {

    public Material skybox;

	// Use this for initialization
	void Start () {
        RenderSettings.skybox = skybox;
	}
}
