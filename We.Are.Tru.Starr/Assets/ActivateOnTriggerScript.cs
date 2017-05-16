using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnTriggerScript : MonoBehaviour {

    public GameObject objectToActivate;

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.name == "TruStarrPlayer") {
            if (objectToActivate != null)
                objectToActivate.SetActive(true);
        }
    }
}
