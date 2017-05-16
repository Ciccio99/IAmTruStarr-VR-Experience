using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMoveTowardHome : MonoBehaviour {

    void OnTriggerEnter(Collider col) {

        if (col.name == "TruStarrPlayer") {
            Destroy(col.gameObject.GetComponent<moveTowardsHome>());
            Destroy(gameObject);
        }
    }
}
