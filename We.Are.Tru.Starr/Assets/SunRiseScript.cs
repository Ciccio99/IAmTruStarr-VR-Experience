using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRiseScript : MonoBehaviour {

    public float timeToMove = 10f;

    private Vector3 finalPostion;
    private Vector3 startPostion;
    private float currentTime = 0f;
    private bool isRising;

	// Use this for initialization
	void Start () {
        finalPostion = gameObject.transform.position;
        startPostion = finalPostion - new Vector3(0, 60, -500);
        isRising = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isRising)
        {
            if (currentTime < timeToMove)
            {
                currentTime += Time.deltaTime;
                transform.position = Vector3.Lerp(startPostion, finalPostion, currentTime / timeToMove);
            }
            else {
                transform.position = finalPostion;
                isRising = false;
            }
        }
	}
}
