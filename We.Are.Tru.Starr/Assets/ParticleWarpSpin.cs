 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleWarpSpin : MonoBehaviour {

    ParticleSystem p_system;
    ParticleSystem.Particle[] particles;

    public float drift = 0.01f;
    public float amplitude = 1.0f;

    float x_drift;
    float y_drift;
    float index;
    
    void InitializeIfNeeded() {
        if (p_system == null) {
            p_system = GetComponent<ParticleSystem>();
        }

        if (particles == null || particles.Length < p_system.main.maxParticles) {
            particles = new ParticleSystem.Particle[p_system.main.maxParticles];
        }
    }

    private void LateUpdate()
    {
        InitializeIfNeeded();

        int numParticlesAlive = p_system.GetParticles(particles);

        index += Time.deltaTime;

        y_drift = Mathf.Sin(index) * amplitude;
        x_drift = Mathf.Cos(index) * amplitude;
        for (int i = 0; i < numParticlesAlive; i++) {
            // particles[i].velocity += Vector3.up * drift;
            //particles[i].rotation3D = new Vector3(x_drift, y_drift, 0);
            transform.Rotate(new Vector3(0, 0, 0.01f * Time.deltaTime));
        }

        p_system.SetParticles(particles, numParticlesAlive);
    }
}
