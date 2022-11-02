using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour {
    public Transform target;
    public bool lateUpdate = true;

    private void Update() {
        if (!lateUpdate)
            transform.LookAt(target.position);
    }

    private void LateUpdate() {
        if (lateUpdate)
            transform.LookAt(target.position);
    }

}
