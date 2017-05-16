using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyParticle : MonoBehaviour {

    private ParticleSystem ps;

    private void Awake()
    {
        if (ps == null) {
            ps = GetComponent<ParticleSystem>();
        }
    }
    // Update is called once per frame
    void Update () {
        if (!ps.IsAlive()) {
            Destroy(gameObject);
        }
	}
}
