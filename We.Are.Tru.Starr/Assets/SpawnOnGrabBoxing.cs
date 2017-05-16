using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnGrabBoxing : MonoBehaviour {

    public GameObject objectToSpawn;

    private NewtonVR.NVRInteractableItem interactScript;
    private bool alreadySpawned;
    private bool otherGloveTouched;
    

    private void Start()
    {
        if (interactScript == null)
        {
            interactScript = GetComponent<NewtonVR.NVRInteractableItem>();
        }

        alreadySpawned = false;
        otherGloveTouched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((interactScript.AttachedHand != null && !alreadySpawned) || 
            (otherGloveTouched && !alreadySpawned))
        {
            Instantiate(objectToSpawn);
            alreadySpawned = true;
        }
    }

    public void OtherGloveTouched() {
        otherGloveTouched = true;
    }
}
