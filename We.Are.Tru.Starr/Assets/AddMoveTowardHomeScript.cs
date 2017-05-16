using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoveTowardHomeScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        if (col.name == "TruStarrPlayer") {
            col.gameObject.AddComponent<moveTowardsHome>();
        }
    }
}
