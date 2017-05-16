using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherGloveSpawnScript : MonoBehaviour {

    public SpawnOnGrabBoxing otherGloveScript;

    private NewtonVR.NVRInteractableItem interactScript;
    private bool alreadySpawned;
    // Use this for initialization
    void Start () {
        if (interactScript == null)
        {
            interactScript = GetComponent<NewtonVR.NVRInteractableItem>();
        }

        if (otherGloveScript == null) {
            otherGloveScript = GameObject.Find("bxglvsp(left)").GetComponent<SpawnOnGrabBoxing>();
        }

        alreadySpawned = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (interactScript.AttachedHand != null && !alreadySpawned) {
            otherGloveScript.OtherGloveTouched();
        }
	}
}
