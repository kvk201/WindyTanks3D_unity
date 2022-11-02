using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowWorldObject : MonoBehaviour {
    public Transform target;
    public BobbingAnimation bob;
    public bool lateUpdate = true;
    public Vector3 offset;

    private Camera cam;

    private void Awake() {
        cam = Camera.main;
    }

    private void Update() {
        if (!lateUpdate)
            Follow();
    }

    private void LateUpdate() {
        if (lateUpdate)
            Follow();
    }

    private void Follow() {
        Vector3 bobOffset = Vector3.zero;
        if (bob)
            bobOffset = bob.GetBobOffset(Vector3.up);

        Vector3 position = cam.WorldToScreenPoint(target.position + offset + bobOffset);
        transform.position = position;
    }
}
