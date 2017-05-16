using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpSkinScript : MonoBehaviour {

	public float tilingRatio = 0.5f;

	Renderer rend;

	float x = 0;
	float y = 0;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
            if (transform.position.z <= -200)
            {
                y = 0;
            }

            if (y < 10)
            {
                y += Time.deltaTime * tilingRatio;
            }
            else
            {
                y = 0;
            }

            rend.material.mainTextureScale = new Vector2(1, y);
	}
}
