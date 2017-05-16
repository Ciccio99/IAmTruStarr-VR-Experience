using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpTunnelSpawnEffect : MonoBehaviour {

    Vector3 finalScale;
    Vector3 startScale = new Vector3(0f, 0f, 0f);
    float progress = 0;
	// Use this for initialization
	void Start () {
        finalScale = gameObject.transform.localScale;
        transform.localScale = startScale;
	}
	
	// Update is called once per frame
	void Update () {
        if (progress < 1)
        {
            progress += Time.deltaTime * 0.3f;
            transform.localScale = Vector3.Lerp(startScale, finalScale, progress);
            transform.Rotate(new Vector3(0, 2, 0));
        }
        else {
            Destroy(this);
        }
	}
}
