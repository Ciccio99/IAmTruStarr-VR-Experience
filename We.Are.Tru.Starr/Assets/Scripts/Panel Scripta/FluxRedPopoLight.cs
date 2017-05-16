using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluxRedPopoLight : MonoBehaviour {

    public float speed = 4;
        
    private Light redLight;
    private float count;

    private void Awake()
    {
        if (redLight == null) {
            redLight = GetComponent<Light>();
        }
    }
	
	// Update is called once per frame
	void Update () {
        count += Time.deltaTime;
        redLight.intensity = Mathf.Abs(Mathf.Sin(count * speed));
	}
}
