using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour {
    public AnimationClip recoil;
    public CannonballSpawner spawner;

    private void Start() {
        spawner.firedDelegate += PlayRecoil;
    }

    private void PlayRecoil(Exploder exp)
    {
        
    }
}
