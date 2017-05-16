using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonSetScript : MonoBehaviour {

    public float timeToMove = 10f;

    private Vector3 finalPosition;
    private Vector3 startPosition;
    private float currentTime = 0f;
    private bool isSetting;

    // Use this for initialization
    void Start()
    {
        startPosition = gameObject.transform.position;
        finalPosition = startPosition - new Vector3(0, 90, 500);
        isSetting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSetting)
        {
            if (currentTime < timeToMove)
            {
                currentTime += Time.deltaTime;
                transform.position = Vector3.Lerp(startPosition, finalPosition, currentTime / timeToMove);
            }
            else
            {
                transform.position = finalPosition;
                isSetting = false;
            }
        }
    }
}
