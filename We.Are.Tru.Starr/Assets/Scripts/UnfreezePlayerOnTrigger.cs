using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnfreezePlayerOnTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TruStarrPlayer")
        {
            Debug.Log("I SHOULD BE UNFROZERN");
            other.gameObject.GetComponent<OVRPlayerController>().enabled = true;
        }
    }
}
