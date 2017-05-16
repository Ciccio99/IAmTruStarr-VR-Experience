using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfOnTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider col) {
        Debug.Log(col.gameObject.name);

        if (col.gameObject.name == "TruStarrPlayer")
        {
            Destroy(gameObject);
        }
    }
}
