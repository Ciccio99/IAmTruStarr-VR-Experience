using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnGrab : MonoBehaviour {

    public GameObject objectToSpawn;

    private NewtonVR.NVRInteractableItem swordInteractScript;
    private bool alreadySpawned;

    private void Start() {
        if (swordInteractScript == null)
        {
            swordInteractScript = GetComponent<NewtonVR.NVRInteractableItem>();
        }

        alreadySpawned = false;

    }

    // Update is called once per frame
    void Update () {
        if (swordInteractScript.AttachedHand != null && !alreadySpawned) {
            Instantiate(objectToSpawn);
            alreadySpawned = true;
        }
	}
}
