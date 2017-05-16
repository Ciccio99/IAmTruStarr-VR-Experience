using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinkleOnBoundaryCollision : MonoBehaviour {

    public GameObject twinkle;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Object_Boundary") {
            Instantiate(twinkle, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
