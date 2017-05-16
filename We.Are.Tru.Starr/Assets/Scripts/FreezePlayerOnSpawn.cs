using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePlayerOnSpawn : MonoBehaviour {

    public OVRPlayerController playerController;

    // Use this for initialization
    void Start()
    {
        if (playerController == null)
        {
            GameObject player = GameObject.Find("TruStarrPlayer");
            playerController = player.GetComponent<OVRPlayerController>();
            playerController.enabled = false;
        }
        
    }
}
