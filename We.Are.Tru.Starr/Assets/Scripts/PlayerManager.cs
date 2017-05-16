using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public void FreezeMovement() {
        GetComponent<OVRPlayerController>().enabled = false;
    }

    public void UnfreezeMovement() {
        GetComponent<OVRPlayerController>().enabled = true;
    }
}
