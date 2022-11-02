using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballWindBlower : MonoBehaviour {
    public Vector_3 windScriptable;
    public float modifier = 1f;

    private Rigidbody rb;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void LateUpdate() {
        rb.AddForce(windScriptable.value * modifier);
    }
}
