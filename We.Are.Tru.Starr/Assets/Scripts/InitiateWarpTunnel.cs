using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateWarpTunnel : MonoBehaviour {

    public GameObject player;
    public GameObject boundaryWalls;

    private void Start()
    {
        if (player == null) {
            player = GameObject.Find("TruStarrPlayer");
            player.AddComponent<moveTowardsWarpTunnel>();
        }

        if (boundaryWalls == null) {
            boundaryWalls = GameObject.FindGameObjectWithTag("BoundaryWalls");
            if (boundaryWalls != null)
                Destroy(boundaryWalls);
        }
    }
}
