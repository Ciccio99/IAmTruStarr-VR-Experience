using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsHome : MonoBehaviour {

    public float speed = 18.0f;
    public Transform homeTarget;

    private PlayerManager playerManager;



	// Use this for initialization
	void Start () {
        if (homeTarget == null) {
            homeTarget = GameObject.Find("HomeTarget").transform;
        }

        if (playerManager == null) {
            playerManager = GetComponent<PlayerManager>();
            playerManager.FreezeMovement();
        }
	}
	
	// Update is called once per frame
	void Update () {
        float step = Time.deltaTime * speed;

        transform.position = Vector3.MoveTowards(transform.position, homeTarget.position, step);
	}

    void OnTriggerEnter(Collider col) {
        Debug.Log("TRIGGERED");
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "HomeTarget") {
            playerManager.UnfreezeMovement();
            Destroy(this);
        }
    }
}
