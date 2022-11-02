using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour {
    public GameObject explosionFX;
    public LayerMask damageable;

    [SerializeField] private Float BlastRadius;

    public Action<Collider[], Vector3> explosionDelegate;

    private void OnCollisionEnter(Collision collision) {
        // create explosion
        Instantiate(explosionFX, transform.position, transform.rotation);

        // check for objects in blast radius
        Collider[] hits = Physics.OverlapSphere(transform.position, BlastRadius.value, damageable);

        // raise event
        if (explosionDelegate != null)
            explosionDelegate(hits, transform.position);

        // destroy the cannonball
        Destroy(gameObject);
    }
}
