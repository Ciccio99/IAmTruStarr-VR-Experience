using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatEffect : MonoBehaviour {

    public float amplitude = 0.5f;
    

    public float setYPos;

    private bool hasCollided = false;
    private bool hasInteracted = false;
    private float index;
    private NewtonVR.NVRInteractableItem interactScript;


    private void Start()
    {
        interactScript = GetComponent<NewtonVR.NVRInteractableItem>();
        setYPos = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update () {

        if (!hasInteracted && interactScript.AttachedHand != null) {
            hasInteracted = true;
        }

        if (!hasCollided && !hasInteracted)
        {
            index += Time.deltaTime;
            transform.localPosition = new Vector3(transform.localPosition.x, (amplitude * Mathf.Sin(index)) + setYPos, transform.localPosition.z);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        hasCollided = true;
    }
}
