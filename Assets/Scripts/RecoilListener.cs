using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoilListener : MonoBehaviour {
    public CannonballSpawner spawner;
    public Animator anim;

    private void Start() {
        spawner.firedDelegate += PlayRecoil;
    }

    private void PlayRecoil(Exploder exp) {
        anim.SetTrigger("Fired");
    }
}
