using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectOnCollision : MonoBehaviour {

    public GameObject objectToSpawn;
    public bool spawnOnce;

    private bool alreadySpawned;

    private void onAwake() {
        alreadySpawned = false;
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("MEOW");
        if (collision.gameObject.tag == "Player" && !alreadySpawned) {
            Instantiate(objectToSpawn);
            alreadySpawned = true;
        }
    }
}
