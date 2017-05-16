using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsWarpTunnel : MonoBehaviour {

    public float speed = 10.0f;
    public string warpTarget = "Warp_Tunnel_Target_Front";

    private GameObject warpTunnel;
    private Vector3 moveTowards;

    // Update is called once per frame
    void Update() {

        if (warpTunnel == null) {
            warpTunnel = GameObject.Find(warpTarget);
        }

        if (warpTunnel != null) {
            moveTowardTunnel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Warp_Tunnel_Target_Front") {
            warpTarget = "Warp_Tunnel_Target_Back";
            warpTunnel = null;
            speed *= 5;
        }

        if (other.gameObject.name == "Warp_Tunnel_Target_Back")
        {
            Destroy(this);
        }
    }

    private void moveTowardTunnel() {
        // Set the step rate with which the player moves towards the tunnel
        float step = speed * Time.deltaTime;

        // Move the player towards the tunnel
        transform.position = Vector3.MoveTowards(transform.position, warpTunnel.transform.position, step);
    }
}
