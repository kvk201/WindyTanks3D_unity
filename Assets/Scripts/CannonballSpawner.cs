using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballSpawner : MonoBehaviour {
    public GameObject cannonballPrefab;
    public Transform parent;
    public Transform spawnPoint;
    public float forceModifier = 1f;
    public AudioSource AudioFire;
    public bool canFire = true;

    public Action<Exploder> firedDelegate;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (canFire) {
                Fire(spawnPoint.position, transform.forward);
                AudioFire.Play();
            }
        }
    }

    public void Fire(Vector3 position, Vector3 force) {
        // instantiate the cannonball as child of parent
        GameObject cannonball = Instantiate(cannonballPrefab, parent) as GameObject;

        // set cannonball's position
        cannonball.transform.position = position;

        // get its rigidbody. set rb to GetComponenet<Rigidbody>()
        Rigidbody rb = cannonball.GetComponent<Rigidbody>();

        // use rb.AddForce() in the direction of forceDirection to get it moving (set ForceMode to Impulse)
        rb.AddForce(force * forceModifier, ForceMode.Impulse);

        // raise the fired event
        if (firedDelegate != null) {
            firedDelegate(cannonball.GetComponent<Exploder>());
        }
    }
}
