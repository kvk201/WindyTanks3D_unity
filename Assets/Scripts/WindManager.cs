using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour {
    public ParticleSystem particles;
    public Wind windScript;

    private ParticleSystem.VelocityOverLifetimeModule velMod;

    private void Awake() {
        velMod = particles.velocityOverLifetime;
    }

    private void Start() {
        Randomize();
    }

    public void Randomize() {
        Vector3 wind = windScript.GetNextWind();
        velMod.x = new ParticleSystem.MinMaxCurve(wind.x);
        velMod.y = new ParticleSystem.MinMaxCurve(wind.y);
        velMod.z = new ParticleSystem.MinMaxCurve(wind.z);
    }
}
