using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectOnForce : MonoBehaviour {

    public GameObject particleTrailEffectPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(particleTrailEffectPrefab, gameObject.transform);
    }
}
