using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initiateWarpSkinEffect : MonoBehaviour {

    private GameObject warpTunnel;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "TruStarrPlayer") {
            
            if (warpTunnel == null) {
                warpTunnel = GameObject.Find("Warp_Tunnel");
                warpTunnel.AddComponent<warpSkinScript>();
            }
        }
    }
}
