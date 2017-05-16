using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopHairOnGrabScript : MonoBehaviour {
    public GameObject objectToActivate;
    public GameObject smokeBlast;

    private NewtonVR.NVRInteractableItem interactScript;
    private bool alreadySpawned;

    // Use this for initialization
    void Start() {
        if (interactScript == null)
        {
            interactScript = GetComponent<NewtonVR.NVRInteractableItem>();
        }

        alreadySpawned = false;
    }

    // Update is called once per frame
    void Update() {
        if (interactScript.AttachedHand != null && !alreadySpawned)
        {
            Invoke("spawnSmoke", 0.7f);
            Invoke("activateHair", 0.8f);
            alreadySpawned = true;
        }
    }

    void spawnSmoke() {
        Instantiate(smokeBlast, transform.position, Quaternion.identity);
    }

    void activateHair() {
        objectToActivate.SetActive(true);
    }
}
